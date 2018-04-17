using Abp.AutoMapper;
using System;
using System.Collections.Generic;
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
    public class CreateMDictInput
    {
        public string dict_code { get; set; }
        public string dict_name { get; set; }
    }
}
