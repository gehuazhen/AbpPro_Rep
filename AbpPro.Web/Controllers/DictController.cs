using Abp.Web.Mvc.Authorization;
using AbpPro.Authorization;
using AbpPro.Dict;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AbpPro.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Users)]
    public class DictController : AbpProControllerBase
    {
        private readonly IDcitAppService _iDcitAppService;
    }
}