namespace MyShop.Models.Cart;


public class ShoppingCartItem
{
    public int ShoppingCartItemId { get; set; }
    public Product Product { get; set; } = default!; //domyslna wartośc dla produktu, wykrzyknik --> zapespieczenie pzed null
    public int Amount { get; set; }
    public string? ShopingCardId { get; set; }
}