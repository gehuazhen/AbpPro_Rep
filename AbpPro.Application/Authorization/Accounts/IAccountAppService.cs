using System.Threading.Tasks;
using Abp.Application.Services;
using AbpPro.Authorization.Accounts.Dto;

namespace AbpPro.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
