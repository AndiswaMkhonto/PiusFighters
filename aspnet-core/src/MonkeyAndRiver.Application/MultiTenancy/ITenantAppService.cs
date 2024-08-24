using Abp.Application.Services;
using MonkeyAndRiver.MultiTenancy.Dto;

namespace MonkeyAndRiver.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

