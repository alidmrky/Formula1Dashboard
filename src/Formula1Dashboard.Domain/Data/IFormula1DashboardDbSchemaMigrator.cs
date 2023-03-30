using System.Threading.Tasks;

namespace Formula1Dashboard.Data;

public interface IFormula1DashboardDbSchemaMigrator
{
    Task MigrateAsync();
}
