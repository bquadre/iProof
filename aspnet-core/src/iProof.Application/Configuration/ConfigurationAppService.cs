using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using iProof.Configuration.Dto;

namespace iProof.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : iProofAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
