using Formula1Dashboard.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Formula1Dashboard.Blazor;

public abstract class Formula1DashboardComponentBase : AbpComponentBase
{
    protected Formula1DashboardComponentBase()
    {
        LocalizationResource = typeof(Formula1DashboardResource);
    }
}
