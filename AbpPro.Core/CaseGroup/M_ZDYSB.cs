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
    public class M_ZDYSB : Entity,IHasCreationTime
    {
        /*
        映射编号	ysbh	int	是	自增列  
        模板号	mb_mbh	varchar(64)	否	
        表列名	excel_column	varchar(64)	否	excel中列头名称
        映射字典代码	sys_colcode	varchar(64)	否	关联M_DICTVALUE表的dict_valcode
        映射字典名称	sys_colname	varchar(64)	否	关联M_DICTVALUE表的dict_valname
        创建时间	createtime	date	否	
        */
        const int MaxNameLength = 64;
        //模板号
        [JsonProperty(PropertyName = "mb_mbh")]
         public int? mb_mbh { get; set; }

        //设置外键
        [ForeignKey("mb_mbh")]
        public M_AJMB m_anmb { get; set; }

        //excel 列明
        [Required]
        [MaxLength(MaxNameLength)]
        [JsonProperty(PropertyName = "excel_column")]
        public string excel_column { get; set; }

        //案件表字段名
        [MaxLength(MaxNameLength)]
        [JsonProperty(PropertyName = "sys_colcode")]
        public string sys_colcode { get; set; }

        //案件表字段说明
        [MaxLength(MaxNameLength)]
        [JsonProperty(PropertyName = "sys_colname")]
        public string sys_colname { get; set; }
        //创建日期
        public DateTime CreationTime { get; set; }
 
        public M_ZDYSB()
        {
            CreationTime = Clock.Now;            
        }
        public M_ZDYSB(int _mb_mbh, string _excel_column, string _sys_colcode,string _sys_colname) :this()
        {
            mb_mbh = _mb_mbh;
            excel_column = _excel_column;
            sys_colcode = _sys_colcode;
            sys_colname = _sys_colname;
        }
 

    }

}
