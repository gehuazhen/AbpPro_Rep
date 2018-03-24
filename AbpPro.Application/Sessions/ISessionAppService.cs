using System.Threading.Tasks;
using Abp.Application.Services;
using AbpPro.Sessions.Dto;

namespace AbpPro.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
