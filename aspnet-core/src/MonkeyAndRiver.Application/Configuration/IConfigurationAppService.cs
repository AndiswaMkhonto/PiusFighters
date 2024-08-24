using System.Threading.Tasks;
using MonkeyAndRiver.Configuration.Dto;

namespace MonkeyAndRiver.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
