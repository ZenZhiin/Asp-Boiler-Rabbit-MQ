using System.Threading.Tasks;
using Ocean.Labs.Configuration.Dto;

namespace Ocean.Labs.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
