using Microsoft.EntityFrameworkCore;

namespace EstiwService.Models
{
    public class EstiwContext : DbContext
    {
        public EstiwContext(DbContextOptions<EstiwContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Customer> Customers { get; set; }
    }
}
