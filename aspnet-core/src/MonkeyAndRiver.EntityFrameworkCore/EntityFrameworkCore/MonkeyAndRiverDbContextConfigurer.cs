using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MonkeyAndRiver.EntityFrameworkCore
{
    public static class MonkeyAndRiverDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MonkeyAndRiverDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MonkeyAndRiverDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
