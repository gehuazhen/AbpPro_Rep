
using Abp.Domain.Repositories;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Text;
using System.Threading.Tasks;
using AbpPro.Tasks.Dto;
using AutoMapper;
using Abp.Timing;
using Abp.Application.Services.Dto;
using Abp.Extensions;

using Abp.AutoMapper;


using Abp.Linq.Extensions;
using AbpPro.Products.Dto;



namespace AbpPro.Products
{
    public class ProductAppService:AbpProAppServiceBase, IProductAppService
    {
        private readonly IRepository<Product> _productRepository;

        public ProductAppService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        /*
        public GetTasksOutput GetTasks(GetTasksInput input)
        {
            var query = _taskRepository.GetAll();
            if(input.AssignedPersonId.HasValue)
            {
                query = query.Where(t => t.AssignedPersonId == input.AssignedPersonId);
            }
            if(input.State.HasValue)
            {
                query = query.Where(t => t.State == input.State);
            }

            return new GetTasksOutput
            {
                Tasks = Mapper.Map<List<TaskDto>>(query.ToList())
            };

        }

        public void UpdateTask(UpdateTaskInput input)
        {
            //We can use Logger, it's defined in ApplicationService base class.
            Logger.Info("Updating a task for input: " + input);

            //Retrieving a task entity with given id using standard Get method of repositories.
            var task = _taskRepository.Get(input.Id);

            //Updating changed properties of the retrieved task entity.

            if (input.State.HasValue)
            {
                task.State = input.State.Value;
            }
            if(input.Title.Length>0)
            {
                task.Title = input.Title;
            }

            //We even do not call Update method of the repository.
            //Because an application service method is a 'unit of work' scope as default.
            //ABP automatically saves all changes when a 'unit of work' scope ends (without any exception).

        }
        public int CreateTask(CreateTaskInput input)
        {
            Logger.Info("Insert into a task for input:" + input);
            var task = new Task
            {
                Title = input.Title,
                Description = input.Description,
                State = input.State,
                CreationTime = Clock.Now
            };
            return _taskRepository.InsertAndGetId(task);
        }

        public TaskDto GetTaskById(int taskId)
        {
            var task = _taskRepository.Get(taskId);

            return Mapper.Map<TaskDto>(task);
        }

       public void DeleteTask(int taskId)
        {
            var task = _taskRepository.Get(taskId);
            if(task!=null)
            {
                _taskRepository.Delete(taskId);
            }
           
        }

        public PagedResultDto<TaskDto> GetPagedTasks(GetTasksInput input)
        {
            //初步过滤
            var query = _taskRepository.GetAll().Include(t => t.AssignedPerson)
                .WhereIf(input.State.HasValue, t => t.State == input.State.Value)
                .WhereIf(!input.Filter.IsNullOrEmpty(), t => t.Title.Contains(input.Filter))
                .WhereIf(input.AssignedPersonId.HasValue, t => t.AssignedPersonId == input.AssignedPersonId.Value);

            //排序
            //query = !string.IsNullOrEmpty(input.Sorting) ? query.OrderBy(input.Sorting) : query.OrderByDescending(t => t.CreationTime);
            query = query.OrderByDescending(t => t.CreationTime);

            //获取总数
            var tasksCount = query.Count();
            //默认的分页方式
            //var taskList = query.Skip(input.SkipCount).Take(input.MaxResultCount).ToList();

            //ABP提供了扩展方法PageBy分页方式
            var taskList = query.PageBy(input).ToList();

            return new PagedResultDto<TaskDto>(tasksCount, taskList.MapTo<List<TaskDto>>());
        }
        */

        public IList<ProductDto> GetAllProducts()
        {
            var products=_productRepository.GetAll();

            return Mapper.Map<IList<ProductDto>>(products);
        }


    }
}
