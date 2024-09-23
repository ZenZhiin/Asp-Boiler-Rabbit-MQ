using Abp.AspNetCore.Mvc.ViewComponents;

namespace Ocean.Labs.Web.Views
{
    public abstract class LabsViewComponent : AbpViewComponent
    {
        protected LabsViewComponent()
        {
            LocalizationSourceName = LabsConsts.LocalizationSourceName;
        }
    }
}
