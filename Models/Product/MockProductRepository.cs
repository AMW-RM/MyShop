namespace MyShop.Models;

public class MockProductRepository : IProductRepository
{
    private readonly ICategoryRepository categoryRepository = new MockCategoryRepository();
    public IEnumerable<Product> AllProducts =>
        new List<Product>
        {
            new Product{ ProductId = 1, Name="Nazwa1", Price=3.00m, LongDescription="Nazwa1", ShortDescription = "NazwaKrotka", Color = "biały", ImageUrl="brak", InStock = true, IsProductOfTheWeek = true, Category = categoryRepository.AllCategories.ToList()[0],
              Rating = 4.5f},

            new Product{ ProductId =2, Name="Nazwa2", Price=3.00m, LongDescription="Nazwa2", ShortDescription = "NazwaKrotka", Color = "biały", ImageUrl="brak", InStock = true, IsProductOfTheWeek = true, Category = categoryRepository.AllCategories.ToList()[2],
              Rating = 4.2f},

              new Product{ ProductId = 3, Name="Nazwa3", Price=3.00m, LongDescription="Nazwa3", ShortDescription = "NazwaKrotka", Color = "biały", ImageUrl="brak", InStock = true, IsProductOfTheWeek = true, Category = categoryRepository.AllCategories.ToList()[1],
              Rating = 2.8f},

               new Product{ ProductId = 4, Name="Nazwa1", Price=3.00m, LongDescription="Nazwa4",
               ShortDescription = "NazwaKrotka", Color = "biały", ImageUrl="brak", InStock = true, IsProductOfTheWeek = true, Category = categoryRepository.AllCategories.ToList()[1],
               Rating = 3.9f},

        };


    public IEnumerable<Product> ProductsOfTheWeek => throw new NotImplementedException();

    public Product GetProductById(int productId)
    {
        throw new NotImplementedException();
    }
}
