using Formula1Dashboard.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Formula1Dashboard.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class Formula1DashboardController : AbpControllerBase
{
    protected Formula1DashboardController()
    {
        LocalizationResource = typeof(Formula1DashboardResource);
    }
}
