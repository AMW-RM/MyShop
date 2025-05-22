using Microsoft.AspNetCore.Mvc;
using MyShop.Models;

namespace MyShop.Components;

public class CategoryMenu : ViewComponent
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryMenu(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public IViewComponentResult Invoke()
    {
        //var categories = _categoryRepository.AllCategories.OrderBy(c => c.Name).ToList();
        return View(_categoryRepository.AllCategories.OrderBy(c => c.Name).ToList());
    }
}
