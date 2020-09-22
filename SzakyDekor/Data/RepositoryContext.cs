using Microsoft.EntityFrameworkCore;

namespace SzakyDekor.Data
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext (DbContextOptions<RepositoryContext> options)
            : base(options)
        {
        }

        public DbSet<Models.User> User { get; set; }

        public DbSet<Models.Product> Product { get; set; }

        public DbSet<Models.ProductCategory> ProductCategory { get; set; }
    }
}
