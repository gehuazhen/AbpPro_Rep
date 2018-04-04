using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbpPro.Tasks.Dto;
using Abp.Application.Services.Dto;
using AbpPro.Products.Dto;

namespace AbpPro.Products
{
    public interface IProductAppService:IApplicationService
    {

 //       GetTasksOutput GetTasks(GetTasksInput input);

 //       void UpdateTask(UpdateTaskInput input);
 //       int  CreateTask(CreateTaskInput input);
 //       PagedResultDto<TaskDto> GetPagedTasks(GetTasksInput input);
 //       TaskDto GetTaskById(int taskId);

//        void DeleteTask(int taskId);

        IList<ProductDto> GetAllProducts();

    }
}
