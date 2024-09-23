using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Ocean.Labs.Configuration;

namespace Ocean.Labs.Web.Host.Startup
{
    [DependsOn(
       typeof(LabsWebCoreModule))]
    public class LabsWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public LabsWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LabsWebHostModule).GetAssembly());
        }
    }
}
