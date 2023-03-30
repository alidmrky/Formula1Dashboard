using Formula1Dashboard.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Formula1Dashboard.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(Formula1DashboardEntityFrameworkCoreModule),
    typeof(Formula1DashboardApplicationContractsModule)
    )]
public class Formula1DashboardDbMigratorModule : AbpModule
{

}
