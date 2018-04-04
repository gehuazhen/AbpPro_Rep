using Abp.Web.Models;
using AbpPro.Tasks;
using AbpPro.Tasks.Dto;
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
using AbpPro.Products;


namespace AbpPro.Web.Controllers
{

    [AbpMvcAuthorize(PermissionNames.Pages_Users)]
    public class ProductsController:AbpProControllerBase
    {
        private readonly IProductAppService _productAppService;
        //private readonly IUserAppService _userAppService;


        public ActionResult Index()
        {
            return View();
        }

        public ProductsController(IProductAppService productAppService, IUserAppService userAppService)
        {
            _productAppService = productAppService;
            
        //_userAppService = userAppService;
    }



        [DontWrapResult]
        public JsonResult GetAllProducts()
        {
         
            var products = _productAppService.GetAllProducts();

            return Json(
                //new{
                // total = pagedTasks.TotalCount,
                // res = products}
                products,
            JsonRequestBehavior.AllowGet);
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