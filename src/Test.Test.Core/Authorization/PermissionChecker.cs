using Abp.Authorization;
using Test.Test.Authorization.Roles;
using Test.Test.Authorization.Users;

namespace Test.Test.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
