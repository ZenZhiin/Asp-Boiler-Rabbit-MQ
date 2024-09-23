using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Ocean.Labs.Authorization;

namespace Ocean.Labs
{
    [DependsOn(
        typeof(LabsCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class LabsApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<LabsAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(LabsApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
