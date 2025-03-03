using API.Entity;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

 public class DataContex(DbContextOptions options) : DbContext(options)
 {
    public DbSet<Product> Products => Set<Product>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>().HasData(
            new List<Product>{
                new Product {Id=1,Name="IPhone 15",Description="Telefon Açıklama",ImageUrl="1.jpg",Price=70000,IsActive=true,Stock=100},
                new Product {Id=2,Name="IPhone 16 Pro",Description="Telefon Açıklama",ImageUrl="2.jpg",Price=80000,IsActive=true,Stock=100},
                new Product {Id=3,Name="IPhone Se 2020",Description="Telefon Açıklama",ImageUrl="3.jpg",Price=50000,IsActive=true,Stock=100},
                new Product {Id=4,Name="IPhone Se 2023",Description="Telefon Açıklama",ImageUrl="4.jpg",Price=60000,IsActive=true,Stock=100}
            }
        );
    }

}