using Microsoft.AspNetCore.Mvc;
using MyShop.Models;
using MyShop.ViewModels;

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

    public IActionResult List()
    {
        ProductListViewModel productListViewModel = new ProductListViewModel
        (
            _productRepository.AllProducts,
            _categoryRepository.AllCategories.First().Name //Where(x => x.CategoryId = 3 
        );

        return View(productListViewModel);
    }
}
