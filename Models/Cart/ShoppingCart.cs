
using Microsoft.EntityFrameworkCore;

namespace MyShop.Models.Cart;

public class ShoppingCart : IShoppingCart
{
    private readonly MyShopDBContects _myShopDBContects;

    public string? ShopingCartId { get; set; }

    public List<ShoppingCartItem> ShoppingCartItems { get; set; } = default!;

    private ShoppingCart(MyShopDBContects myShopDBContects)
    {
        _myShopDBContects = myShopDBContects;
    }

    public static ShoppingCart GetCart(IServiceProvider serviceProvider)
    {
        ISession? session = serviceProvider.GetRequiredService<IHttpContextAccessor>()?.HttpContext?.Session;

        string cartId = session?.GetString("CartId") ?? Guid.NewGuid().ToString();
        session?.SetString("CartId", cartId);

        var context = serviceProvider.GetService<MyShopDBContects>() ?? throw new Exception("Error pobrania danych dbContext");

        return new ShoppingCart(context) { ShopingCartId = cartId };
    }

    public void AddToCart(Product product)
    {
        var shoppingCartItem = _myShopDBContects.ShoppingCartItems.SingleOrDefault(p =>
            p.Product.ProductId == product.ProductId &&
            p.ShopingCardId == ShopingCartId);
        if (shoppingCartItem == null)
        {
            shoppingCartItem = new ShoppingCartItem
            {
                ShopingCardId = ShopingCartId,
                Product = product,
                Amount = 1
            };

            _myShopDBContects.ShoppingCartItems.Add(shoppingCartItem);
        }
        else
            shoppingCartItem.Amount++;

        _myShopDBContects.SaveChanges();
    }

    public void ClearCart()
    {
        var shoppingCart = _myShopDBContects.ShoppingCartItems.Where(p =>
          p.ShopingCardId == ShopingCartId);
        _myShopDBContects.ShoppingCartItems.RemoveRange(shoppingCart);
        _myShopDBContects.SaveChanges();
    }

    public decimal GetShopingCartTotal()
    {
        var total = _myShopDBContects.ShoppingCartItems
            .Where(p => p.ShopingCardId == ShopingCartId)
            .Select(p => p.Product.Price * p.Amount)
            .Sum();
        return total;
    }

    public List<ShoppingCartItem> GetShoppingCartItems()
    {
        return ShoppingCartItems ??= _myShopDBContects.ShoppingCartItems
            .Where(p => p.ShopingCardId == ShopingCartId)
            .Include(p => p.Product).ToList();
    }

    public int RemoveFromCart(Product product)
    {
        var shoppingCartItem = _myShopDBContects.ShoppingCartItems.SingleOrDefault(p =>
          p.Product.ProductId == product.ProductId &&
          p.ShopingCardId == ShopingCartId);
        var localAmount = 0;
        if (shoppingCartItem != null )
        {
            if (shoppingCartItem.Amount > 1)
            {
                shoppingCartItem.Amount--;
                localAmount = shoppingCartItem.Amount;
            }           
            else
           _myShopDBContects.ShoppingCartItems.Remove(shoppingCartItem);    
          
        }
         _myShopDBContects.SaveChanges();
        return localAmount;
    }
}
