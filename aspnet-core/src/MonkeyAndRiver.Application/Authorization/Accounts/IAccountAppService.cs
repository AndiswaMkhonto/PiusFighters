using System.Threading.Tasks;
using Abp.Application.Services;
using MonkeyAndRiver.Authorization.Accounts.Dto;

namespace MonkeyAndRiver.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
