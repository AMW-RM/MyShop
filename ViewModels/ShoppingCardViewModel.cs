using MyShop.Models.Cart;

namespace MyShop.ViewModels;

public class ShoppingCardViewModel
{
    public IShoppingCart ShoppingCart{ get; set; }
    public decimal ShoppingCartTotal { get; set; }
    public ShoppingCardViewModel(IShoppingCart shoppingCart, decimal shoppingCartTotal)
    {
        ShoppingCart = shoppingCart;
        ShoppingCartTotal = shoppingCartTotal;
    }

}
