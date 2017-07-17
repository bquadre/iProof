using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using iProof.Roles.Dto;
using iProof.Users.Dto;

namespace iProof.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}