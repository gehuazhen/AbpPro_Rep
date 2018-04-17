using Abp.Application.Services.Dto;
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
	 * date: 2018-04-15
	 * modify:add
	 */
    public class MDictDto : EntityDto
    {
        public string dict_code { get; set; }

        public string dict_name { get; set; }

        //创建日期
        public DateTime CreationTime { get; set; }



        public override string ToString()
        {
            return string.Format(
                "[Dict Id={0}, dict_code={1}, dict_name={2}, CreationTime={3}",
                Id,
                dict_code,
                dict_name,
                CreationTime
                );
        }
       
        /// <summary>
        /// 根据任务状态，获取定义的css样式
        /// </summary>
        /// <returns></returns>
        public string GetDict()
        {
            return "";
        }
    }
}
