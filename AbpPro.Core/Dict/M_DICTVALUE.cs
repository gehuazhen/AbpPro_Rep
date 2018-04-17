using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpPro.Dict
{
    /**
	 * description: 字典小类
	 * author: hys
	 * date: 2018-04-17
	 * modify:add
	 */
   public class M_DICTVALUE : Entity, IHasCreationTime
    {
        const int MaxNameLength = 64;


        //大类代码
        [Required]
        [MaxLength(MaxNameLength)]
        [JsonProperty(PropertyName = "dict_code")]
        public string dict_code { get; set; }

        //小类代码
        [Required]
        [MaxLength(MaxNameLength)]
        [JsonProperty(PropertyName = "dict_valcode")]
        public string dict_valcode { get; set; }

        //小类名称
        [Required]
        [MaxLength(MaxNameLength)]
        [JsonProperty(PropertyName = "dict_valname")]
        public string dict_valname { get; set; }


        //创建日期
        public DateTime CreationTime { get; set; }

        public M_DICTVALUE()
        {
            CreationTime = Clock.Now;
        }
        public M_DICTVALUE( string _dict_valcode, string _dict_valname) : this()
        {
            dict_valcode = _dict_valcode;
            dict_valname = _dict_valname;
        }
    }
}
