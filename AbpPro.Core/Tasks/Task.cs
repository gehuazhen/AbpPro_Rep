using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using AbpPro.Authorization.Users;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AbpPro.Tasks
{
    public class Task:Entity,IHasCreationTime
    {
        public const int MaxTitleLength = 256;
        public const int MaxDescLength = 64 * 1024;//64kb

        public long? AssignedPersonId { get; set; }

        [ForeignKey("AssignedPersonId")]
        public User AssignedPerson { get; set; }

        [Required]
        [MaxLength(MaxTitleLength)]
        public string Title { get; set; }

        public string Description { get; set; }

        public TaskState State { get; set; }

        public DateTime CreationTime { get; set; }


        public Task()
        {
            CreationTime = Clock.Now;
            State = TaskState.Open;
        }

        public Task(string title,string desc=null):this()
        {
            Title = title;
            Description = desc;
        }

    }
    public enum TaskState:byte
    {
        Open=0,
        Completed=1
    }
}
