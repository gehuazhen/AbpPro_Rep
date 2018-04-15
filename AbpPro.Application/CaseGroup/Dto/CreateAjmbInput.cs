using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpPro.CaseGroup.Dto
{
    [AutoMapTo(typeof(M_AJMB))] //定义单向映射
    public class CreateAjmbInput
    {

        public string mb_mbmc { get; set; }
        public string mb_cjr { get; set; }

    }
}
