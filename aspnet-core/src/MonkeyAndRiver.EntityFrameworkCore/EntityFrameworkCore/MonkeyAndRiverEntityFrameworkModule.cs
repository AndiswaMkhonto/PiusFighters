using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using MonkeyAndRiver.EntityFrameworkCore.Seed;

namespace MonkeyAndRiver.EntityFrameworkCore
{
    [DependsOn(
        typeof(MonkeyAndRiverCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class MonkeyAndRiverEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<MonkeyAndRiverDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        MonkeyAndRiverDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        MonkeyAndRiverDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MonkeyAndRiverEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
