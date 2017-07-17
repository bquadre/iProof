using System.Threading.Tasks;
using Abp.Application.Services;
using iProof.Sessions.Dto;

namespace iProof.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
