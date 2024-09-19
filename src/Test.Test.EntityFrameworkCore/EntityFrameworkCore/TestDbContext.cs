using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Test.Test.Authorization.Roles;
using Test.Test.Authorization.Users;
using Test.Test.MultiTenancy;

namespace Test.Test.EntityFrameworkCore
{
    public class TestDbContext : AbpZeroDbContext<Tenant, Role, User, TestDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public TestDbContext(DbContextOptions<TestDbContext> options)
            : base(options)
        {
        }
    }
}
