using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Ocean.Labs.Controllers
{
    public abstract class LabsControllerBase: AbpController
    {
        protected LabsControllerBase()
        {
            LocalizationSourceName = LabsConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
