using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace iProof.Controllers
{
    public abstract class iProofControllerBase: AbpController
    {
        protected iProofControllerBase()
        {
            LocalizationSourceName = iProofConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}