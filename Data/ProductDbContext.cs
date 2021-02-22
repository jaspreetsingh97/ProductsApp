using Microsoft.EntityFrameworkCore;

namespace ProductsApp.Data{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options):base(options)
        {
        }
        public DbSet<ProductsApp.Models.ProductModel> ProductsModel { get; set; }
    }
}