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
	 * description: 字典小类
	 * author: hys
	 * date: 2018-04-17
	 * modify:add
	 */
    [AutoMapTo(typeof(M_DICT))] //定义单向映射
    public class UpdateMDictValueInput : ICustomValidate
    {

        [Required]
        public string dict_valcode { get; set; }
        [Required]
        public string dict_valname { get; set; }


        public void AddValidationErrors(CustomValidationContext context)
        {
            //  if (AssignedPersonId == null && State == null)
            //  {
            //      context.Results.Add(new ValidationResult("Both of AssignedPersonId and State can not be null in order to update a Task!", new[] { "AssignedPersonId", "State" }));
            //  }
        }
    }
}
