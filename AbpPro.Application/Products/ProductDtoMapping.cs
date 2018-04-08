using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using AbpPro;
using AutoMapper;
using AbpPro.Products.Dto;

namespace AbpPro.Products
{
    class ProductDtoMapping : IDtoMapping
    {
        public void CreateMapping(IMapperConfigurationExpression mapperConfig)
        {
            //定义单向映射

            //自定义映射
            var productDtoMapper = mapperConfig.CreateMap<Product, ProductDto>();
            productDtoMapper.ForMember(dto => dto.StrUuid, map => map.MapFrom(m => m.Uuid.ToString()));
        }
    }
}
