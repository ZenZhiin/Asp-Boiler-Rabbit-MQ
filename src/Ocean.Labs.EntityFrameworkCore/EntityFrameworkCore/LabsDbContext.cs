using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Ocean.Labs.Authorization.Roles;
using Ocean.Labs.Authorization.Users;
using Ocean.Labs.MultiTenancy;
using Ocean.Labs.Model;

namespace Ocean.Labs.EntityFrameworkCore
{
    public class LabsDbContext : AbpZeroDbContext<Tenant, Role, User, LabsDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public LabsDbContext(DbContextOptions<LabsDbContext> options)
            : base(options)
        {

        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductStock> ProductStocks { get; set; }
    }
}
