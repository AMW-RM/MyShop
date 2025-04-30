using Microsoft.EntityFrameworkCore;

namespace MyShop.Models;

public class MyShopDBContects : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }

    public MyShopDBContects(DbContextOptions<MyShopDBContects> contextOptions):base(contextOptions)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        //modelBuilder.Entity<Category>(entity =>
        //{
        //    entity.ToTable("Category");
        //    entity.HasKey(c => c.CategoryId);
        //    entity.Property(c => c.Name).IsRequired().HasMaxLength(100);
        //});
    }

}
