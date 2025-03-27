using Microsoft.AspNetCore.Mvc;
using MyShop.Models;

namespace MyShop.Controllers;

public class ProductController : Controller
{
    private readonly IProductRepository _productRepository;
    private readonly ICategoryRepository _categoryRepository;

    public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
    {
        _productRepository = productRepository;
        _categoryRepository = categoryRepository;
    }

    public  IActionResult List()
    {
        ViewBag.CurrentCategory = "chemia";
        var products = _productRepository.AllProducts;
        return View(products);
    }
}
