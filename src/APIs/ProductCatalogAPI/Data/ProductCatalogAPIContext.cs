using Microsoft.EntityFrameworkCore;

namespace ProductCatalogAPI.Data
{
    public class ProductCatalogAPIContext : DbContext
    {
        public ProductCatalogAPIContext (DbContextOptions<ProductCatalogAPIContext> options)
            : base(options)
        {
        }

        public DbSet<ProductCatalogAPI.Models.ProductCategory> ProductCategory { get; set; }

        public DbSet<ProductCatalogAPI.Models.Product> Product { get; set; }
    }
}
