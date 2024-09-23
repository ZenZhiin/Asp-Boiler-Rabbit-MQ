using Abp.Authorization;
using Ocean.Labs.Authorization.Roles;
using Ocean.Labs.Authorization.Users;

namespace Ocean.Labs.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
