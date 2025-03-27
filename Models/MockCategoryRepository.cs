
namespace MyShop.Models;

public class MockCategoryRepository : ICategoryRepository
{

    public IEnumerable<Category> AllCategories => new List<Category> //nie muszę dodawać return
    {
        new Category
        {
            CategoryId = 1,
            Name = "Chemia",
            Description = "Chemia budowlana"
        },
        new Category
        {
            CategoryId = 2,
            Name = "Spożywka",
            Description = "Art spożywcze"
        },
        new Category
        {
            CategoryId = 3,
            Name = "Napoje",
            Description = "Wina"
        }

    };


    //public IEnumerable<Category> AllCategories()
    //{
    //    var categories = new List<Category>();
    //    categories.Add(new Category { CategoryId = 1, Name = "Chemia", Description = "Budowlana" });
    //    categories.Add(new Category { CategoryId = 2, Name = "Napoje", Description = "Wina" });
    //    categories.Add(new Category { CategoryId = 3, Name = "Owoce", Description = "Brak" });
    //    return categories;

    //}
}
