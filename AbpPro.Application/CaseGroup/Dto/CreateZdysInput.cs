using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpPro.CaseGroup.Dto
{
    [AutoMapTo(typeof(M_ZDYSB))] //定义单向映射
    public class CreateZdysInput
    {
        //模板号
        public int? mb_mbh { get; set; }

        //excel 列名
        public string excel_column { get; set; }

        //案件表字段名
        public string sys_colcode { get; set; }

        //案件表字段说明
        public string sys_colname { get; set; }

    }
}
