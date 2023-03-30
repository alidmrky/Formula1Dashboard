using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Formula1Dashboard.Data;

/* This is used if database provider does't define
 * IFormula1DashboardDbSchemaMigrator implementation.
 */
public class NullFormula1DashboardDbSchemaMigrator : IFormula1DashboardDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
