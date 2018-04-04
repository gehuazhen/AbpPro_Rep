using System.Web.Mvc;
using Abp.Application.Navigation;
using Abp.Threading;
using Abp.Web.Models;
using Abp.Web.Mvc.Authorization;
using AbpPro.Web.Models.Layout;

using Abp.Runtime.Session;

namespace AbpPro.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : AbpProControllerBase
    {
        private readonly IUserNavigationManager _userNavigationManager;

        public HomeController(IUserNavigationManager userNavigationManager)
        {
            _userNavigationManager = userNavigationManager;

        }


        public ActionResult Index()
        {
            return View();
        }


        [DontWrapResult]
        public JsonResult GetMenuInfo()
        {
            var model = new SideBarNavViewModel
            {
                MainMenu = AsyncHelper.RunSync(() => _userNavigationManager.GetMenuAsync("MainMenu", AbpSession.ToUserIdentifier())),
                //ActiveMenuItemName = activeMenu
            };
            return Json(
                model,
                JsonRequestBehavior.AllowGet);

        }

    }
}