using Abp.Authorization;
using iProof.Authorization.Roles;
using iProof.Authorization.Users;
using iProof.MultiTenancy;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Options;

namespace iProof.Identity
{
    public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
    {
        public SecurityStampValidator(
            IOptions<IdentityOptions> options, 
            SignInManager signInManager) 
            : base(options, signInManager)
        {
        }
    }
}