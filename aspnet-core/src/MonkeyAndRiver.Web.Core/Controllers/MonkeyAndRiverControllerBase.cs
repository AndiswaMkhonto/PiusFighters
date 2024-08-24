using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MonkeyAndRiver.Controllers
{
    public abstract class MonkeyAndRiverControllerBase: AbpController
    {
        protected MonkeyAndRiverControllerBase()
        {
            LocalizationSourceName = MonkeyAndRiverConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
