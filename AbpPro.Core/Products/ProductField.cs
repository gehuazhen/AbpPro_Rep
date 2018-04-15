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

namespace AbpPro.Products
{
    public class ProductField : Entity
    {
     
  
        //JsonProperty 

        //"code": "字段代码",
       // [JsonProperty(PropertyName ="code")]
        public string Code { get; set; }
        //"name": "文字说明",
       // [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
     

     
        //public ProductField(string code,string name  )//:this()
        //{

        //    Code = code;
        //    Name = name;

        //}
 

    }

}
