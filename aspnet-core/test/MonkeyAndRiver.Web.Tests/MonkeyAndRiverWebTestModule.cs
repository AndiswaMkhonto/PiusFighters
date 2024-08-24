using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MonkeyAndRiver.EntityFrameworkCore;
using MonkeyAndRiver.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace MonkeyAndRiver.Web.Tests
{
    [DependsOn(
        typeof(MonkeyAndRiverWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class MonkeyAndRiverWebTestModule : AbpModule
    {
        public MonkeyAndRiverWebTestModule(MonkeyAndRiverEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MonkeyAndRiverWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MonkeyAndRiverWebMvcModule).Assembly);
        }
    }
}