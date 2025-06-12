namespace MyShop.Models.Cart
{
    public interface IShoppingCart
    {
        void AddToCart(Product product);
        int RemoveFromCart(Product product);
        List<ShoppingCartItem> GetShoppingCartItems();
        void ClearCart();
        decimal GetShopingCartTotal();
        List<ShoppingCartItem> ShoppingCartItems { get; set; }
    }

}
