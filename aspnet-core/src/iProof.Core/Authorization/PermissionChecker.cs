using Abp.Authorization;
using iProof.Authorization.Roles;
using iProof.Authorization.Users;

namespace iProof.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
