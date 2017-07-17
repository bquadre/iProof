using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using iProof.Roles.Dto;

namespace iProof.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
