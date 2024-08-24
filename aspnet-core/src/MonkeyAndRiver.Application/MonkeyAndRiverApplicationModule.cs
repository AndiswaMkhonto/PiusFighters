using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MonkeyAndRiver.Authorization;

namespace MonkeyAndRiver
{
    [DependsOn(
        typeof(MonkeyAndRiverCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MonkeyAndRiverApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MonkeyAndRiverAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MonkeyAndRiverApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
