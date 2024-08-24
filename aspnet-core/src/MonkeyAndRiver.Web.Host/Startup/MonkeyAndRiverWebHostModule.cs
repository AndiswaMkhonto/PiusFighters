using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MonkeyAndRiver.Configuration;

namespace MonkeyAndRiver.Web.Host.Startup
{
    [DependsOn(
       typeof(MonkeyAndRiverWebCoreModule))]
    public class MonkeyAndRiverWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MonkeyAndRiverWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MonkeyAndRiverWebHostModule).GetAssembly());
        }
    }
}
