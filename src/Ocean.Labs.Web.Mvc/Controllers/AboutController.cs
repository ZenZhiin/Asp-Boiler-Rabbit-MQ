using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Ocean.Labs.Controllers;

namespace Ocean.Labs.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : LabsControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
