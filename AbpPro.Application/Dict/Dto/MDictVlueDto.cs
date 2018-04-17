using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
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
    public class MDictVlueDto : EntityDto
    {
        public string dict_valcode { get; set; }
        public string dict_valname { get; set; }
        public DateTime CreationTime { get; set; }

        public override string ToString()
        {
            return string.Format(
                "[DictValue Id={0}, dict_valcode={1}, dict_valname={2}, CreationTime={3}",
                Id,
                dict_valcode,
                dict_valname,
                CreationTime
                );
        }

        /// <summary>
        /// 根据任务状态，获取定义的css样式
        /// </summary>
        /// <returns></returns>
        public string GetDictValue()
        {
            return "";
        }
    }
}
