using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AbpPro.Tasks;
using AbpPro.Users;
using AbpPro.Tasks.Dto;
using AbpPro.Web.Models.Tasks;
using Abp.Application.Services.Dto;

namespace AbpPro.Web.Controllers
{
    public class TasksController : AbpProControllerBase
    {

        IUserAppService _userAppService;
        ITaskAppService _taskAppService;
        public TasksController(IUserAppService userAppService , ITaskAppService taskAppService)
        {
            _userAppService = userAppService;
            _taskAppService = taskAppService;
        }


 //       [ChildActionOnly]
        public  async System.Threading.Tasks.Task<PartialViewResult> Create()
        {
            var userList =  (await _userAppService.GetAll(new PagedResultRequestDto { MaxResultCount = int.MaxValue })); //GetUsers();
            ViewBag.AssignedPersonId = new SelectList(userList.Items, "Id", "Name");
            return PartialView("_CreateTask");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateTaskInput task)
        {
            var id = _taskAppService.CreateTask(task);

            var input = new GetTasksInput();
            var output = _taskAppService.GetTasks(input);

            return PartialView("_List", output.Tasks);
        }

        public async System.Threading.Tasks.Task<PartialViewResult> Edit(int id)
        {
            var task = _taskAppService.GetTaskById(id);

            var updateTaskDto = AutoMapper.Mapper.Map<UpdateTaskInput>(task);

            var userList = (await _userAppService.GetAll(new PagedResultRequestDto {  MaxResultCount=10 }));
            ViewBag.AssignedPersonId = new SelectList(userList.Items, "Id", "Name", updateTaskDto.AssignedPersonId);

            return PartialView("_EditTask", updateTaskDto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UpdateTaskInput updateTaskDto)
        {
            _taskAppService.UpdateTask(updateTaskDto);

            var input = new GetTasksInput();
            var output = _taskAppService.GetTasks(input);

            return PartialView("_List", output.Tasks);
        }



        public PartialViewResult GetList(GetTasksInput input)
        {
            var output = _taskAppService.GetTasks(input);
            return PartialView("_List", output.Tasks);
        }




        // GET: Tasks
        public ActionResult Index(GetTasksInput input)
        {

            var output = _taskAppService.GetTasks(input);

            var model = new IndexViewModel(output.Tasks)
            {
                SelectedTaskState = input.State

            };
            return View(model);

        }
    }
}