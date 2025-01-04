
using System;
using Microsoft.EntityFrameworkCore;
using EfCachingApp.DataAccess.Entities;

namespace EfCachingApp.DataAccess;

public class AppDbContext : DbContext
{
    public DbSet<Product> Product { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {


    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>().HasKey(t => t.ProductId);
        modelBuilder.Entity<Product>().Property(t => t.ProductId)
            .IsRequired();
        
        modelBuilder.Entity<Product>().Property(t => t.ProductName);

    }

}