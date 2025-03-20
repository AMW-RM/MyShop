namespace MyShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();//w³¹czamy kolekcje MVC
            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");
            if (app.Environment.IsDevelopment())//tryb development
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.MapDefaultControllerRoute();//mozliwoœæ nawigacji na stronach
            app.Run();

           

        }
    }
}
