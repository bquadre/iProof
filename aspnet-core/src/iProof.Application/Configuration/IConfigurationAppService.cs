using System.Threading.Tasks;
using iProof.Configuration.Dto;

namespace iProof.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}