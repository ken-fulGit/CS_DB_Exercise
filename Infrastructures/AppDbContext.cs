using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS_DB_Exercise.Infrastructures.Entitties;
using CS_DB_Exercise.Infrastructures.Queries;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic;

namespace CS_DB_Exercise.Infrastructures;

public class AppDbContext : DbContext
{
    public DbSet<ItemEntity>? Items { set; get; } = null;
    public DbSet<ItemCategoryEntity>? ItemCategories { set; get; } = null;
    public DbSet<EmployeeEntity>? Employees { set; get; } = null;
    public DbSet<DepartmentEntity>? Departments { set; get; } = null;
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = "Host=localhost;Database=cs_db_exercise;Username=postgres;Password=postgres;";
        optionsBuilder.UseNpgsql(connectionString)
        .LogTo(Console.WriteLine, LogLevel.Information)
        .EnableSensitiveDataLogging();

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ItemEntity>()
            .ToTable("item")
            .Property(i => i.CategoryId)
            .HasColumnName("category_id");
        modelBuilder.Entity<ItemCategoryEntity>()
            .ToTable("item_category");

        modelBuilder.Entity<ItemEntity>()
            .HasOne(i => i.ItemCatogory)
            .WithMany(c => c.Items)
            .HasForeignKey(i => i.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);
    }

}
