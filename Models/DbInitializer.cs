namespace MyShop.Models;

public static class DbInitializer
{
    public static void Seed(IApplicationBuilder app)
    {
        var context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<MyShopDBContects>();

        if (!context.Categories.Any())
        {
            context.Categories.AddRange(
                new Category { Name = "Chemia" },
                new Category { Name = "Spożywka" },
                new Category { Name = "Alkohol" }
           );
            context.SaveChanges(); 

        }
        var categories = context.Categories.ToDictionary(c => c.Name, c => c.CategoryId);

        if (!context.Products.Any())
        {
            context.Products.AddRange
            (
                new Product { Name = "Proszek", Price = 30.00m, LongDescription = "Właściwy opis produktu pierwszego", ShortDescription = "Skrócony Opis produktu pierwszego", Color = "biały", ImageUrl = "/images/product.jpg", InStock = true, IsProductOfTheWeek = true, CategoryId = categories["Chemia"], Rating = 4.5f, Dupa = "T" },
                new Product { Name = "Pepsi", Price = 10.00m, LongDescription = "Właściwy opis produktu drugiego", ShortDescription = "Skrócony Opis produktu drugiego", Color = "czarny", ImageUrl = "/images/product.jpg", InStock = true, IsProductOfTheWeek = true, CategoryId = categories["Alkohol"], Rating = 3.6f, Dupa = "T" },
                new Product { Name = "Chleb", Price = 15.00m, LongDescription = "Właściwy opis produktu trzeciego", ShortDescription = "Skrócony Opis produktu trzeciego", Color = "zielony", ImageUrl = "/images/product.jpg", InStock = false, IsProductOfTheWeek = false, CategoryId = categories["Spożywka"], Rating = 4f, Dupa = "T" },
                new Product { Name = "Masło", Price = 20.00m, LongDescription = "Właściwy opis produktu czwartego", ShortDescription = "Skrócony Opis produktu czwartego", Color = "niebieski", ImageUrl = "/images/product.jpg", InStock = true, IsProductOfTheWeek = false, CategoryId = categories["Spożywka"], Rating = 5f, Dupa = "T" },
                new Product { Name = "Mydło", Price = 30.00m, LongDescription = "Właściwy opis produktu piatego", ShortDescription = "Skrócony Opis produktu piatego", Color = "różowy", ImageUrl = "/images/product.jpg", InStock = true, IsProductOfTheWeek = false, CategoryId = categories["Chemia"], Rating = 2.5f, Dupa = "T" },
                new Product { Name = "CocaColla", Price = 40.00m, LongDescription = "Właściwy opis produktu szóstego", ShortDescription = "Skrócony Opis produktu szóstego", Color = "fioletowy", ImageUrl = "/images/product.jpg", InStock = false, IsProductOfTheWeek = true, CategoryId = categories["Alkohol"], Rating = 4.6f, Dupa = "T" },
                new Product { Name = "Ogórki", Price = 30.00m, LongDescription = "Właściwy opis produktu siódmego", ShortDescription = "Skrócony Opis produktu siódmego", Color = "pomarańczowy", ImageUrl = "/images/product.jpg", InStock = true, IsProductOfTheWeek = false, CategoryId = categories["Spożywka"], Rating = 3f, Dupa = "T" },
                new Product { Name = "Sprite", Price = 35.00m, LongDescription = "Właściwy opis produktu ósmego", ShortDescription = "Skrócony Opis produktu ósmego", Color = "niebieski", ImageUrl = "/images/product.jpg", InStock = true, IsProductOfTheWeek = false, CategoryId = categories["Alkohol"], Rating = 5f, Dupa = "T" },
                new Product { Name = "Wybielacz", Price = 36.00m, LongDescription = "Właściwy opis produktu dziewiątego", ShortDescription = "Skrócony Opis produktu dziewiątego", Color = "bordowy", ImageUrl = "/images/product.jpg", InStock = false, IsProductOfTheWeek = false, CategoryId = categories["Chemia"], Rating = 4.5f, Dupa = "T" }
            );
            context.SaveChanges();
        }

    }
}

