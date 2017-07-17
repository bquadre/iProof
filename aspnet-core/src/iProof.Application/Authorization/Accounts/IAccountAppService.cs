using System.Threading.Tasks;
using Abp.Application.Services;
using iProof.Authorization.Accounts.Dto;

namespace iProof.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
