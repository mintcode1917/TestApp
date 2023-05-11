using Microsoft.EntityFrameworkCore;
using TestApp.Models.Entities;

namespace TestApp.DataLayer;

/// <summary>
/// Контекст бд
/// </summary>
public class DataDbContext : DbContext
{
    /// <summary>
    /// Элементы списка
    /// </summary>
    public DbSet<Element> Elements => Set<Element>();

    /// ctor
    public DataDbContext(DbContextOptions<DataDbContext> options) : base(options) { }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Element>().HasKey(u => u.Number);
    }
}