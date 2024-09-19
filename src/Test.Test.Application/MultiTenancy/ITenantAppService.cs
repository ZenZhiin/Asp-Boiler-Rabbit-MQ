using Abp.Application.Services;
using Test.Test.MultiTenancy.Dto;

namespace Test.Test.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

