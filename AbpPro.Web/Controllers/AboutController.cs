using System.Web.Mvc;

namespace AbpPro.Web.Controllers
{
    public class AboutController : AbpProControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}