using System.Collections.Generic;
using System.Linq;
using Abp.Configuration;
using Abp.Localization;
using Abp.Net.Mail;
using AbpPro.EntityFramework;
using AbpPro.Tasks;

namespace AbpPro.Migrations.SeedData
{
    public class DefaultTasksCreator
    {
        private readonly AbpProDbContext _context;

        public static List<Task> InitalTasks { get; private set; }
        public DefaultTasksCreator(AbpProDbContext context)
        {
            _context = context;
        }


         static  DefaultTasksCreator()
        {
            InitalTasks = new List<Task>
            {
                new Task("检查bug","查看每个作业是否正常！"),
                new Task("检查bug","查看每个作业是否正常！")
            };
        }



        public void Create()
        {
            CreateTasks();
        }

        public void CreateTasks()
        {
            foreach(var task in InitalTasks)
            {
                AddTaskIfNotExists(task);
            }
        }

        private void AddTaskIfNotExists(Task task)
        {
            if (_context.Tasks.Any(s => s.Title == task.Title && s.Description == task.Description))
            {
                return;
            }

            _context.Tasks.Add(task);
            _context.SaveChanges();
        }
    }
}