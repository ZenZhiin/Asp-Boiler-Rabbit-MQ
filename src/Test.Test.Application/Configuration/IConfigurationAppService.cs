using System.Threading.Tasks;
using Test.Test.Configuration.Dto;

namespace Test.Test.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
