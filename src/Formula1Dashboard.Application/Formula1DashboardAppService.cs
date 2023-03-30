using System;
using System.Collections.Generic;
using System.Text;
using Formula1Dashboard.Localization;
using Volo.Abp.Application.Services;

namespace Formula1Dashboard;

/* Inherit your application services from this class.
 */
public abstract class Formula1DashboardAppService : ApplicationService
{
    protected Formula1DashboardAppService()
    {
        LocalizationResource = typeof(Formula1DashboardResource);
    }
}
