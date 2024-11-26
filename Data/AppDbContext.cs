using Microsoft.EntityFrameworkCore;
using MVC_2024.Models;

namespace MVC_2024.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
}

