using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Ocean.Labs.Web.Views
{
    public abstract class LabsRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected LabsRazorPage()
        {
            LocalizationSourceName = LabsConsts.LocalizationSourceName;
        }
    }
}
