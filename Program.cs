using MyShop.Models;

namespace MyShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();//w��czamy kolekcje MVC

            builder.Services.AddScoped<ICategoryRepository, MockCategoryRepository>();
            builder.Services.AddScoped<IProductRepository, MockProductRepository>();

            var app = builder.Build();


            //app.MapGet("/", () => "Hello World!");
            if (app.Environment.IsDevelopment())//tryb development
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.MapDefaultControllerRoute();//mozliwo�� nawigacji na stronach
            app.Run();

           

        }
    }
}
