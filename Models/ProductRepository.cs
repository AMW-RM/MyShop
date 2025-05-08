
using Microsoft.EntityFrameworkCore;

namespace MyShop.Models;

public class ProductRepository : IProductRepository
{
    private readonly MyShopDBContects _myShopDBContects;

    public ProductRepository(MyShopDBContects myShopDBContects)
    {
        _myShopDBContects = myShopDBContects;
    }
    public IEnumerable<Product> AllProducts
    {
        get
        {
           return _myShopDBContects.Products.Include(c => c.Category);
        }
    }


    public IEnumerable<Product> ProductsOfTheWeek
    {
        get
        {
            return _myShopDBContects.Products.Include(c =>c.Category).Where(c => c.IsProductOfTheWeek);
        }
    }

    public Product? GetProductById(int productId)
    {
        return _myShopDBContects.Products.FirstOrDefault(f => f.ProductId == productId);
    }

}
