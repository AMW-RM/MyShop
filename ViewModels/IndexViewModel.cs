using MyShop.Models;

namespace MyShop.ViewModels;

public class IndexViewModel
{
    public string HeroTitle { get; set; }
    public string HeroDescription { get; set; }
    public string AboutTitle { get; set; }
    public string AboutText { get; set; }
    public List<ServiceItem> Services { get; set; }
    public string CtaTitle { get; set; }
    public string CtaText { get; set; }
    public List<Product> ProductsOfTheWeek { get; set; }
}

public class ServiceItem
{
    public string Title { get; set; }
    public string Description { get; set; }
}


