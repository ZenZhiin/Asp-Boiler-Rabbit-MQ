using Abp.Application.Services;
using Ocean.Labs.MultiTenancy.Dto;

namespace Ocean.Labs.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

