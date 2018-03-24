using System.Threading.Tasks;
using Abp.Application.Services;
using AbpPro.Configuration.Dto;

namespace AbpPro.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}