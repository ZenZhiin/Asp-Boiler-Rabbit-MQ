using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Ocean.Labs.EntityFrameworkCore
{
    public static class LabsDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<LabsDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<LabsDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
