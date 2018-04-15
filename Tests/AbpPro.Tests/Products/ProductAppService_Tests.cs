using System.Data.Entity;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using AbpPro.Products;
using AbpPro.Users;
using AbpPro.Users.Dto;
using Shouldly;
using Xunit;

namespace AbpPro.Tests.Products
{
    public class ProductAppService_Tests : AbpProTestBase
    {
        private readonly IProductAppService _productAppService;

        public ProductAppService_Tests()
        {
            _productAppService = Resolve<IProductAppService>();
        }

        [Fact]
        public void GetProductTableField_Test()
        {
            //Act
            _productAppService.GetProductTableFields();

            //Assert
            //output.Items.Count.ShouldBeGreaterThan(0);
        }

 
    }
}
