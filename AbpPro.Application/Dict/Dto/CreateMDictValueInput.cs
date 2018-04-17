using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpPro.Dict.Dto
{
    /**
    * description: 字典小类
    * author: 黄永生
    * date: 2018-04-17
    * modify:add
    */
    [AutoMapTo(typeof(M_DICTVALUE))] //定义单向映射
   public class CreateMDictValueInput
    {
        public string dict_valcode { get; set; }
        public string dict_valname { get; set; }
    }
}
