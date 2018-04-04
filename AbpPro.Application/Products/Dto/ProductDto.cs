using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpPro.Products.Dto
{
    public class ProductDto : EntityDto
    {
        //"uuid": "04C2141B-B74A-11E4-98B5-782BCBD7746B",
        public Guid Uuid { get; set; }
        //"category_id": "6C2AFC9A-B3F3-11E4-9DEA-782BCBD7746B",
        public Guid CategoryId { get; set; }
        //"code": "2103",
        public string Code { get; set; }
        //"name": "\u590f\u666e\u7a7a\u6c14\u51c0\u5316\u5668xxxxccc",
        public string Name { get; set; }
        //"parent_id": "0",

        public string ParentId { get; set; }
        //"sale_price": "1399.00",

        public float? SalePrice { get; set; }
        //"spec": "KC-W200SW",

        public string Spec { get; set; }
        //"unit_id": "5D6D901E-B3F3-11E4-9DEA-782BCBD7746B",
     
        public Guid? UnitId { get; set; }
        //"purchase_price": "0.00",

        public float? PurchasePrice { get; set; }
        //"py": "XPKQJHQ",
     
        public string Py { get; set; }
        //"spec_py": null,
   
        public string SpecPy { get; set; }
        //"bar_code": null,
 
        public string BarCode { get; set; }
        //"data_org": "01010001",

        public string DataOrg { get; set; }
        //"memo": "",

        public string Memo { get; set; }
        //"company_id": "4D74E1E4-A129-11E4-9B6A-782BCBD7746B",

        public Guid? CompanyId { get; set; }
        //"brand_id": null,
     
        public string BrandId { get; set; }
        //"unit": null,
      
        public string Unit { get; set; }
        //"rate": 25

        public float? Rate { get; set; }
        public DateTime CreationTime { get; set; }




    }
}
