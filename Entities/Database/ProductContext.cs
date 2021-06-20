using Microsoft.EntityFrameworkCore;

namespace Entities.Database
{
    public class ProductContext: DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options): base(options)
        {

        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Product> Products { get; set; }


        public DbSet<User> Users{ get; set; }

        public DbSet<Order> Orders { get; set; }
    }
}
