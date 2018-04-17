using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;


/**
 * description: 字典大类
 * author: 黄永生 
 * date: 2018-04-15
 * modify:add
 */
namespace AbpPro.Dict
{
    public class M_DICT : Entity, IHasCreationTime
    {

        const int MaxNameLength = 64;

        //大类代码
        [Required]
        [MaxLength(MaxNameLength)]
        [JsonProperty(PropertyName = "dict_code")]
        public string dict_code { get; set; }

        //大类名称
        [Required]
        [MaxLength(MaxNameLength)]
        [JsonProperty(PropertyName = "dict_name")]
        public string dict_name { get; set; }

    
        //创建日期
        public DateTime CreationTime { get; set; }

        public M_DICT()
        {
            CreationTime = Clock.Now;
        }
        public M_DICT(string _dict_code, string _dict_name) : this()
        {
            dict_code = _dict_code;
            dict_name = _dict_name;
        }

    }
}
