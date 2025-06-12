namespace MyShop.Models;

public interface ICategoryRepository
{
    IEnumerable<Category> AllCategories { get; } //dla odwolania ze strzałką lambda
    //IEnumerable<Category> AllCategories();

}
