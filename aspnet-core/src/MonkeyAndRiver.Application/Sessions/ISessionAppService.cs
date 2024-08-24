using System.Threading.Tasks;
using Abp.Application.Services;
using MonkeyAndRiver.Sessions.Dto;

namespace MonkeyAndRiver.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
