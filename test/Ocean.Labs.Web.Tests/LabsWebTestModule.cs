using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Ocean.Labs.EntityFrameworkCore;
using Ocean.Labs.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Ocean.Labs.Web.Tests
{
    [DependsOn(
        typeof(LabsWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class LabsWebTestModule : AbpModule
    {
        public LabsWebTestModule(LabsEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LabsWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(LabsWebMvcModule).Assembly);
        }
    }
}