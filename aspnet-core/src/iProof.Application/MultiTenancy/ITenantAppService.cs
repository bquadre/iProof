using Abp.Application.Services;
using Abp.Application.Services.Dto;
using iProof.MultiTenancy.Dto;

namespace iProof.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
