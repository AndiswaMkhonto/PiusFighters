using Abp.Authorization;
using MonkeyAndRiver.Authorization.Roles;
using MonkeyAndRiver.Authorization.Users;

namespace MonkeyAndRiver.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
