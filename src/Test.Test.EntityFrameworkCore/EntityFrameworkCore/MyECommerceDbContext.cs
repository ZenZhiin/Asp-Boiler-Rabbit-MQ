using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Test.Test.Model;

public class MyECommerceDbContext : AbpDbContext
{
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductStock> ProductStocks { get; set; }

    public MyECommerceDbContext(DbContextOptions<MyECommerceDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configure entity mappings here
    }
}
