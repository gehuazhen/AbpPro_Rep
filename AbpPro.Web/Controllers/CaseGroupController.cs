using Abp.Web.Models;
using AbpPro.CaseGroup.Dto;
using AbpPro.Users;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Abp.Application.Services.Dto;
using Abp.Web.Mvc.Authorization;
using AbpPro.Authorization;
using Newtonsoft.Json;
using System.IO;
using AbpPro.CaseGroup;


namespace AbpPro.Web.Controllers
{

    [AbpMvcAuthorize(PermissionNames.Pages_Users)]
    public class CaseGroupController : AbpProControllerBase
    {
        private readonly ICaseGroupAppService _caseGroupAppService;
        //private readonly IUserAppService _userAppService;


        public ActionResult Index()
        {
            return View();
        }

        public CaseGroupController(ICaseGroupAppService caseGroupAppService, IUserAppService userAppService)
        {
            _caseGroupAppService = caseGroupAppService;
            
        //_userAppService = userAppService;
    }



        [DontWrapResult]
        public JsonResult GetAllAjmb()
        {
 
            var ajbm = _caseGroupAppService.GetAjmb();

            return Json(
                //new{
                // total = pagedTasks.TotalCount,
                // res = products}
                ajbm.Ajmb,
            JsonRequestBehavior.AllowGet);
        }

        //       [ChildActionOnly]
        public  PartialViewResult GetAjmbView()
        {
            return PartialView("_CreateAjmb");
        }

        [HttpPost]
        [DontWrapResult]
        public JsonResult StationImport()
        {
            HttpPostedFileBase file = Request.Files["file"];
            string FileName;
            string savePath;


            var res = new
            {
                statusCode = 200,
                title = "操作提示",
                message = "文件上传成功！当statusCode为200时，返回成功提示信息。",
                filePath = "/uploads/file/2017103011215432467.xls"
            };
            return Json(res);
        }



        [HttpPost]
        [DontWrapResult]
        // [ValidateAntiForgeryToken]
        public JsonResult CreateAjmb(CreateAjmbInput ajmb)
        {
            var id = _caseGroupAppService.CreateAjmb(ajmb); //(task);

            var res = new
            {
                statusCode = 200,
                title = "200",
                message = "恭喜你，操作成功！当statusCode为200时，返回成功提示信息。"
            };
            return Json( res);
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        [DontWrapResult]
        public JsonResult DeleteAjmb(int id )
        {

            _caseGroupAppService.DeleteAjmb(id);
            var res = new
            {
                statusCode = 200,
                title = "200",
                message = "恭喜你，操作成功！当statusCode为200时，返回成功提示信息。"

            };
            return Json(res);
        }

        /*
        [DontWrapResult]
        public JsonResult GetAllTasks(int limit, int offset, string sortfiled, string sortway, string search, string status)
        {
            var sort = !string.IsNullOrEmpty(sortfiled) ? string.Format("{0} {1}", sortfiled, sortway) : "";
            TaskState currentState;
            if (!string.IsNullOrEmpty(status)) Enum.TryParse(status, true, out currentState);

            var filter = new GetTasksInput
            {
                SkipCount = offset,
                MaxResultCount = limit,
                Sorting = sort,
                Filter = search
            };

            if (!string.IsNullOrEmpty(status)) if (Enum.TryParse(status, true, out currentState)) filter.State = currentState;

            var pagedTasks = _taskAppService.GetPagedTasks(filter);

            return Json(new
            {
                total = pagedTasks.TotalCount,
                rows = pagedTasks.Items
            },
            JsonRequestBehavior.AllowGet);
        }
        
             [HttpPost]
             [ValidateAntiForgeryToken]
             public JsonResult Create(CreateTaskInput task)
             {
                 var id = _productAppService.CreateTask(task);

                 return Json(id, JsonRequestBehavior.AllowGet);
             }



             [HttpPost]
             [ValidateAntiForgeryToken]
             public JsonResult Edit(UpdateTaskInput updateTaskDto)
             {
                 if (ModelState.IsValid)
                 {
                     _taskAppService.UpdateTask(updateTaskDto);

                     return Json(true, JsonRequestBehavior.AllowGet);
                 }
                 return Json(false, JsonRequestBehavior.AllowGet);
             }
     */



    }
}