using Microsoft.AspNetCore.Mvc;
using MyShop.Models;
using MyShop.Models.Cart;
using MyShop.ViewModels;

namespace MyShop.Controllers;

public class ShoppingCartController : Controller
{
    private readonly IShoppingCart _shoppingCart;
    private readonly IProductRepository _productRepository;

    public ShoppingCartController(IShoppingCart shoppingCart, IProductRepository productRepository)
    {
        _shoppingCart = shoppingCart;
        _productRepository = productRepository;

    }
    #region Metody
    public IActionResult Index()
    {
        var items = _shoppingCart.GetShoppingCartItems();
        _shoppingCart.ShoppingCartItems = items;

        var total = _shoppingCart.GetShopingCartTotal();

#if (false)
        var total2 = _shoppingCart.GetShopingCartTotal();
#endif   
        var shoppingCartViewModel = new ShoppingCardViewModel(_shoppingCart, total);

        return View(shoppingCartViewModel);
    }
    public RedirectToActionResult AddToShoppingCart(int ProductId)
    {
        var selectedProduct = _productRepository.GetProductById(ProductId);
        if (selectedProduct != null)
        {
            _shoppingCart.AddToCart(selectedProduct);
        }

        return RedirectToAction("Index");
    }

    public RedirectToActionResult RemoveFromShoppingCart(int ProductId)
    {
        var selectedProduct = _productRepository.GetProductById(ProductId);
        if (selectedProduct != null)
        {
            _shoppingCart.RemoveFromCart(selectedProduct);
        }

        return RedirectToAction("Index");
    }

    #endregion

}
