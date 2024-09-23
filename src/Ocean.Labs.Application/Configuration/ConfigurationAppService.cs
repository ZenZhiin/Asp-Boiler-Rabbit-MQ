using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Ocean.Labs.Configuration.Dto;

namespace Ocean.Labs.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : LabsAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
