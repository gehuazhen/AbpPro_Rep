using Abp.AutoMapper;
using Abp.Runtime.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpPro.CaseGroup.Dto
{
    [AutoMapTo(typeof(Task))] //定义单向映射
    public class UpdateAjmbInput:ICustomValidate
    {

        [Range(1, Int32.MaxValue)] //Data annotation attributes work as expected.
        public int Id { get; set; }


        [Required]
        public string mb_mbmc { get; set; }
        [Required]
        public string mb_cjr { get; set; }


        public void AddValidationErrors(CustomValidationContext context)
        {
          //  if (AssignedPersonId == null && State == null)
          //  {
          //      context.Results.Add(new ValidationResult("Both of AssignedPersonId and State can not be null in order to update a Task!", new[] { "AssignedPersonId", "State" }));
          //  }
        }
        

    }
}
