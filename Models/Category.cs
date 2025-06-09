namespace MyShop.Models;

public class Category : IComparable<Category>
{
    public int CategoryId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public List<Product> Products { get; set; }

    public int CompareTo(Category? other)
    {
        if (other == null) return 1;

        return string.Compare(this.Name, other.Name, StringComparison.Ordinal);
        
    }
}