using eCommerceApp.Domain.Entities;

namespace eCommerceApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Product> Product { get; set; }
    public DbSet<Category> Categories { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure decimal precision for Price
        modelBuilder.Entity<Product>()
            .Property(p => p.Price)
            .HasPrecision(18, 2); // 18 digits total, 2 digits after decimal

        base.OnModelCreating(modelBuilder);
    }

}