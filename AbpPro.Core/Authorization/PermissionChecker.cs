using Abp.Authorization;
using AbpPro.Authorization.Roles;
using AbpPro.Authorization.Users;

namespace AbpPro.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
