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
    public class Product:Entity,IHasCreationTime
    {
        /*
              "uuid": "04C2141B-B74A-11E4-98B5-782BCBD7746B",
              "category_id": "6C2AFC9A-B3F3-11E4-9DEA-782BCBD7746B",
              "code": "2103",
              "name": "\u590f\u666e\u7a7a\u6c14\u51c0\u5316\u5668xxxxccc",
              "parent_id": "0",
              "sale_price": "1399.00",
              "spec": "KC-W200SW",
              "unit_id": "5D6D901E-B3F3-11E4-9DEA-782BCBD7746B",
              "purchase_price": "0.00",
              "py": "XPKQJHQ",
              "spec_py": null,
              "bar_code": null,
              "data_org": "01010001",
              "memo": "",
              "company_id": "4D74E1E4-A129-11E4-9B6A-782BCBD7746B",
              "brand_id": null,
              "unit": null,
              "rate": 25
        */

        public const int MaxNameLength = 256;
        public const int MaxDescLength = 64 * 1024;//64kb      
        
        //JsonProperty 

        //"uuid": "04C2141B-B74A-11E4-98B5-782BCBD7746B",
        [JsonProperty(PropertyName ="uuid")]
        public Guid Uuid { get; set; }
        //"category_id": "6C2AFC9A-B3F3-11E4-9DEA-782BCBD7746B",
        [JsonProperty(PropertyName = "category_id")]
        public Guid CategoryId { get; set; }
        //"code": "2103",
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }
        //"name": "\u590f\u666e\u7a7a\u6c14\u51c0\u5316\u5668xxxxccc",
        [Required]
        [MaxLength(MaxNameLength)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        //"parent_id": "0",
        [JsonProperty(PropertyName = "parent_id")]
        public string ParentId { get; set; }
        //"sale_price": "1399.00",
        [JsonProperty(PropertyName = "sale_price")]
        public float? SalePrice { get; set; }
        //"spec": "KC-W200SW",
        [JsonProperty(PropertyName = "spec")]
        public string Spec { get; set; }
        //"unit_id": "5D6D901E-B3F3-11E4-9DEA-782BCBD7746B",
        [JsonProperty(PropertyName = "unit_id")]
        public Guid? UnitId { get; set; }
        //"purchase_price": "0.00",
        [JsonProperty(PropertyName = "purchase_price")]
        public float? PurchasePrice { get; set; }
        //"py": "XPKQJHQ",
        [JsonProperty(PropertyName = "py")]
        public string Py { get; set; }
        //"spec_py": null,
        [JsonProperty(PropertyName = "spec_py")]
        public string SpecPy { get; set; }
        //"bar_code": null,
        [JsonProperty(PropertyName = "bar_code")]
        public string BarCode { get; set; }
        //"data_org": "01010001",
        [JsonProperty(PropertyName = "data_org")]
        public string DataOrg { get; set; }
        //"memo": "",
        [JsonProperty(PropertyName = "memo")]
        public string Memo { get; set; }
        //"company_id": "4D74E1E4-A129-11E4-9B6A-782BCBD7746B",
        [JsonProperty(PropertyName = "company_id")]
        public Guid? CompanyId { get; set; }
        //"brand_id": null,
        [JsonProperty(PropertyName = "brand_id")]
        public string BrandId { get; set; }
        //"unit": null,
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }
        //"rate": 25
        [JsonProperty(PropertyName = "rate")]
        public float? Rate { get; set; }
        public DateTime CreationTime { get; set; }

        //设置属性默认值
        public Product()
        {
            CreationTime = Clock.Now;            
        }
        public Product(Guid uuid , Guid categoryId, string code,string name, string parentId, float salePrice,string spec
            , Guid unitId,float purchasePrice,string py,string specPy,string barCode,string dataOrg
            , string memo,Guid companyId,string brandId,string  unit,float rate  ):this()
        {
            Uuid = uuid;
            CategoryId = categoryId;
            Code = code;
            Name = name;
            ParentId = parentId;
            SalePrice = salePrice;
            Spec = spec;
            UnitId = unitId;
            PurchasePrice = purchasePrice;
            Py = py;
            SpecPy = specPy;
            BarCode = barCode;
            DataOrg = dataOrg;
            Memo = memo;
            CompanyId = companyId;
            BrandId = brandId;
            Unit = unit;
            Rate = rate;



        }
 

    }

}
