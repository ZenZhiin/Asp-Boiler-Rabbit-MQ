using System.Threading.Tasks;
using Abp.Application.Services;
using Ocean.Labs.Authorization.Accounts.Dto;

namespace Ocean.Labs.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
