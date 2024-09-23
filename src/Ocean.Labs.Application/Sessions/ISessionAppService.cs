using System.Threading.Tasks;
using Abp.Application.Services;
using Ocean.Labs.Sessions.Dto;

namespace Ocean.Labs.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
