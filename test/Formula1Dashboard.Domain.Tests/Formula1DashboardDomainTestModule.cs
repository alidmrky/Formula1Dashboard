using Formula1Dashboard.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Formula1Dashboard;

[DependsOn(
    typeof(Formula1DashboardEntityFrameworkCoreTestModule)
    )]
public class Formula1DashboardDomainTestModule : AbpModule
{

}
