using ShoppingCart.Models;
using Microsoft.EntityFrameworkCore;

namespace ShoppingCart.Data
{
    public class ShoppingContext : DbContext
    {
        public ShoppingContext(DbContextOptions<ShoppingContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Cateogary> Cateogaries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Cateogary>().ToTable("Cateogary");

        }

    }
}