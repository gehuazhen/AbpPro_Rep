using Abp.AutoMapper;
using Abp.Runtime.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpPro.Dict.Dto
{
    /**
   * description: 字典大类
   * author: 黄永生
   * date: 2018-04-16
   * modify:add
   */
    [AutoMapTo(typeof(M_DICT))] //定义单向映射
    public class UpdateMDictInput : ICustomValidate
    {

        [Required]
        public string dict_code { get; set; }
        [Required]
        public string dict_name { get; set; }


        public void AddValidationErrors(CustomValidationContext context)
        {
            //  if (AssignedPersonId == null && State == null)
            //  {
            //      context.Results.Add(new ValidationResult("Both of AssignedPersonId and State can not be null in order to update a Task!", new[] { "AssignedPersonId", "State" }));
            //  }
        }

    }
}
