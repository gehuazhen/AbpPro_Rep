using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AbpPro.MultiTenancy.Dto;

namespace AbpPro.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
