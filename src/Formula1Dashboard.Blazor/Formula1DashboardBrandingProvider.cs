using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Formula1Dashboard.Blazor;

[Dependency(ReplaceServices = true)]
public class Formula1DashboardBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Formula1Dashboard";
}
