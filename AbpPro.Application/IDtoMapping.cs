using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpPro
{
    internal interface IDtoMapping
    {
        void CreateMapping(IMapperConfigurationExpression  mapperConfiger);
    }
}
