using Volo.Abp.Modularity;

namespace Formula1Dashboard;

[DependsOn(
    typeof(Formula1DashboardApplicationModule),
    typeof(Formula1DashboardDomainTestModule)
    )]
public class Formula1DashboardApplicationTestModule : AbpModule
{

}
