using Microsoft.EntityFrameworkCore;
using MyShop.Models;


namespace MyShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();//w��czamy kolekcje MVC
           
            //builder.Services.AddScoped<ICategoryRepository, MockCategoryRepository>();
            builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
            // builder.Services.AddScoped<IProductRepository, MockProductRepository>();
            builder.Services.AddScoped<IProductRepository, ProductRepository>();
            builder.Services.AddScoped<IIndexRepository, MockIndexRepository>();
            builder.Services.AddScoped<IContactRepository, MockContactRepository>();
            builder.Services.AddScoped<IAboutRepository, MockAboutRepository>();
            builder.Services.AddDbContext<MyShopDBContects>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("MyShopDbContextConnection"));
            });

            var app = builder.Build();


            //app.MapGet("/", () => "Hello World!");
            if (app.Environment.IsDevelopment())//tryb development
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            //app.MapDefaultControllerRoute();//mozliwo�� nawigacji na stronach, kontroler [domyslnie:home, action-->index]
                                            // �{controller=Home}/{action=Index}/{id?}�

            app.MapControllerRoute(
                name:"handlowiec",
                pattern:"{controller=Home}/{action=Index}/{id?}" );

            DbInitializer.Seed(app);
            app.Run();

           

        }
    }
}
