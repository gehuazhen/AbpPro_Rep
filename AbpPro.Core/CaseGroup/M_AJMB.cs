using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using AbpPro.Authorization.Users;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;

namespace AbpPro.CaseGroup
{
    public class M_AJMB:Entity,IHasCreationTime
    {
        /*
            模板号	mb_mbh	varchar(64)	是
            模板名称	mb_mbmc	varchar(64)	否
            创建人	mb_cjr	varchar(64)	否
            创建日期	mb_createtime	date	否

        */
        const int MaxNameLength = 64;

        //模板号
        [JsonProperty(PropertyName = "mb_mbh")]
        public Guid mb_mbh { get; set; }

        //模板名称
        [Required]
        [MaxLength(MaxNameLength)]
        [JsonProperty(PropertyName = "mb_mbmc")]
        public string mb_mbmc { get; set; }

        //创建人
        [MaxLength(MaxNameLength)]
        [JsonProperty(PropertyName = "mb_cjr")]
        public string mb_cjr { get; set; }

        //创建日期
        public DateTime CreationTime { get; set; }
 
        public M_AJMB()
        {
            CreationTime = Clock.Now;            
        }
        public M_AJMB(Guid _mb_mbh, string _mb_mbmc, string _mb_cjr  ):this()
        {
            mb_mbh = _mb_mbh;
            mb_mbmc = _mb_mbmc;
            mb_cjr = _mb_cjr;

        }
 

    }

}
