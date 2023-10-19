using Microsoft.EntityFrameworkCore;
using TP3.Models;

namespace TP3
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Product>().HasKey(m => m.Id);

            base.OnModelCreating(builder);
        }
    }
}
