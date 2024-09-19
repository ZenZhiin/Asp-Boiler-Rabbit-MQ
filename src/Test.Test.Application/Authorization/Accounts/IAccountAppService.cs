using System.Threading.Tasks;
using Abp.Application.Services;
using Test.Test.Authorization.Accounts.Dto;

namespace Test.Test.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
