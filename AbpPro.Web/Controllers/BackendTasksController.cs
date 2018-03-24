﻿using Abp.Web.Models;
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

namespace AbpPro.Web.Controllers
{

    [AbpMvcAuthorize(PermissionNames.Pages_Users)]
    public class BackendTasksController:AbpProControllerBase
    {

        private readonly ITaskAppService _taskAppService;
        private readonly IUserAppService _userAppService;

        public BackendTasksController(ITaskAppService taskAppService, IUserAppService userAppService)
        {
            _taskAppService = taskAppService;
            _userAppService = userAppService;
        }

        // GET: Task
        public async  System.Threading.Tasks.Task<ActionResult> List()
        {
            ViewBag.TaskStateDropdownList = GetTaskStateDropdownList(null);
            var userList = ( await _userAppService.GetAll(new PagedResultRequestDto { MaxResultCount = 100 })); // GetUsers();
            ViewBag.AssignedPersonId = new SelectList(userList.Items, "Id", "Name");
            return View();
        }


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
            var id = _taskAppService.CreateTask(task);

            return Json(id, JsonRequestBehavior.AllowGet);
        }

        public  async System.Threading.Tasks.Task< PartialViewResult> Edit(int id)
        {
            var task = _taskAppService.GetTaskById(id);

            var updateTaskDto = Mapper.Map<UpdateTaskInput>(task);

            var userList = (await _userAppService.GetAll(new PagedResultRequestDto { MaxResultCount = 100 })); 
            ViewBag.AssignedPersonId = new SelectList(userList.Items, "Id", "Name", updateTaskDto.AssignedPersonId);

            return PartialView("_EditTask", updateTaskDto);
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


        private List<SelectListItem> GetTaskStateDropdownList(TaskState? curState)
        {
            var list = new List<SelectListItem>
            {
                new SelectListItem
                {
                    Text = "AllTasks",
                    Value = "",
                    Selected = curState == null
                }
            };

            list.AddRange(Enum.GetValues(typeof(TaskState))
                .Cast<TaskState>()
                .Select(state => new SelectListItem
                {
                    Text = $"TaskState_{state}",
                    Value = state.ToString(),
                    Selected = state == curState
                })
            );

            return list;
        }

    }
}