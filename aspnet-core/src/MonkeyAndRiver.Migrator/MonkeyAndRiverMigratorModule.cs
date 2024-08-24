using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MonkeyAndRiver.Configuration;
using MonkeyAndRiver.EntityFrameworkCore;
using MonkeyAndRiver.Migrator.DependencyInjection;

namespace MonkeyAndRiver.Migrator
{
    [DependsOn(typeof(MonkeyAndRiverEntityFrameworkModule))]
    public class MonkeyAndRiverMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public MonkeyAndRiverMigratorModule(MonkeyAndRiverEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(MonkeyAndRiverMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                MonkeyAndRiverConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MonkeyAndRiverMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
