
namespace MyShop.Models;

public class CategoryRepository : ICategoryRepository
{
    private readonly MyShopDBContects myShopDBContects;

    public CategoryRepository(MyShopDBContects _myShopDBContects)
    {
        myShopDBContects = _myShopDBContects;
    }
    public IEnumerable<Category> AllCategories => myShopDBContects.Categories.OrderBy(c => c.Name);

    public IEnumerable<Category> AllCategories2
    {
        get
        {
            return myShopDBContects.Categories.OrderBy(c => c.Name);
        }
    }
}
