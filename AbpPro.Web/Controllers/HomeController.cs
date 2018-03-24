using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace AbpPro.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : AbpProControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}