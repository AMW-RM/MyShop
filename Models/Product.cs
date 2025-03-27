using System.ComponentModel;

namespace MyShop.Models;

public class Product
{
    public int ProductId { get; set; } //dla int domyslne 0 
    public string Name { get; set; } = string.Empty;
    public string? ShortDescription { get; set; } //wartość nie wymagana
    public string? LongDescription { get; set; }
    public decimal Price { get; set; }
    public string? Color { get; set; }
    public string? ImageUrl { get; set; }
    public bool IsProductOfTheWeek { get; set; }
    public bool InStock { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; } = default!;
}
