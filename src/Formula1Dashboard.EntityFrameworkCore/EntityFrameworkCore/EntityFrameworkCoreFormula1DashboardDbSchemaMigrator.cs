using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Formula1Dashboard.Data;
using Volo.Abp.DependencyInjection;

namespace Formula1Dashboard.EntityFrameworkCore;

public class EntityFrameworkCoreFormula1DashboardDbSchemaMigrator
    : IFormula1DashboardDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreFormula1DashboardDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the Formula1DashboardDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<Formula1DashboardDbContext>()
            .Database
            .MigrateAsync();
    }
}
