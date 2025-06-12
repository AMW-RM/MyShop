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

    public IActionResult List(string category)
    {
        IEnumerable<Product> products;
        string? currentCategory;

        if (string.IsNullOrEmpty(category))
        {
            products = _productRepository.AllProducts.
                OrderBy(c => c.Category);

            currentCategory = "Wszystkie";
        }
        else
        {
            products = _productRepository.AllProducts
                .Where(c => c.Category.Name == category)
                .OrderBy(c => c.Name);

            currentCategory = _categoryRepository.AllCategories
                .FirstOrDefault(c => c.Name == category)?.Name;
        }

          return View(new ProductListViewModel(products, currentCategory));
    }
    public IActionResult Details(int id)
    {
        var product = _productRepository.GetProductById(id);
        if (product == null)
            return NotFound();
        return View(product);

    }
}
