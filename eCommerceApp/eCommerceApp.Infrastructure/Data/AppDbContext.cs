using eCommerceApp.Domain.Entities;

namespace eCommerceApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Product> Product { get; set; }
    public DbSet<Category> Categories { get; set; }

}