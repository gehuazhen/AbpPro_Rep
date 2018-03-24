using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AbpPro.Configuration.Dto;

namespace AbpPro.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AbpProAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
