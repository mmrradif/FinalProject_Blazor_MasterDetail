using Microsoft.EntityFrameworkCore;
using MyApp.Shared.Models;

namespace MyApp.Server
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) { }
        public DbSet<Customer> Customers { get; set; } = default!;
        public DbSet<Order> Orders { get; set; } = default!;
        public DbSet<OrderItem> OrderItems { get; set; } = default!;
        public DbSet<Product> Products { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderItem>().HasKey(o => new { o.OrderID, o.ProductID });
        }
    }
}
