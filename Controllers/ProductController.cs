using Microsoft.AspNetCore.Mvc;
using MyShop.Models;
using MyShop.ViewModels;
using System.Numerics;

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
        //var category = _categoryRepository.AllCategories.FirstOrDefault(x => x.CategoryId == 2);
        var category = _categoryRepository.AllCategories.FirstOrDefault();
        ProductListViewModel productListViewModel = new ProductListViewModel
        (
            _productRepository.AllProducts, 
            category.Name
        );

        return View(productListViewModel);
    }
    public IActionResult Details(int id)
    {
        var product = _productRepository.GetProductById(id);
        if (product == null) 
            return NotFound();
        return View(product);

    }
}
