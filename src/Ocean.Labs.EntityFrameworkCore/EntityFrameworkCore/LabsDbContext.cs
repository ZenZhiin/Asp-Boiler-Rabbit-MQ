using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Ocean.Labs.Authorization.Roles;
using Ocean.Labs.Authorization.Users;
using Ocean.Labs.MultiTenancy;

namespace Ocean.Labs.EntityFrameworkCore
{
    public class LabsDbContext : AbpZeroDbContext<Tenant, Role, User, LabsDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public LabsDbContext(DbContextOptions<LabsDbContext> options)
            : base(options)
        {
        }
    }
}
