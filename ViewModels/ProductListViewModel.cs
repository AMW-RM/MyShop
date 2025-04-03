using MyShop.Models;

namespace MyShop.ViewModels;

public class ProductListViewModel
{
    public IEnumerable<Product> Products { get; } //= Enumerable.Empty<Product>();
    public string? CurrentCategory { get; }

    public ProductListViewModel(IEnumerable<Product> products, string? currentCategory)
    {
        Products = products;
        CurrentCategory = currentCategory;
    }
}
