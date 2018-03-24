using Abp.AutoMapper;
using AbpPro.Sessions.Dto;

namespace AbpPro.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}