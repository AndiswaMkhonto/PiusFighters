using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MonkeyAndRiver.Authorization.Roles;
using MonkeyAndRiver.Authorization.Users;
using MonkeyAndRiver.MultiTenancy;

namespace MonkeyAndRiver.EntityFrameworkCore
{
    public class MonkeyAndRiverDbContext : AbpZeroDbContext<Tenant, Role, User, MonkeyAndRiverDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MonkeyAndRiverDbContext(DbContextOptions<MonkeyAndRiverDbContext> options)
            : base(options)
        {
        }
    }
}
