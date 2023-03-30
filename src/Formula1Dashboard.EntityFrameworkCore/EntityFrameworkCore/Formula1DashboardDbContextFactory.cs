using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Formula1Dashboard.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class Formula1DashboardDbContextFactory : IDesignTimeDbContextFactory<Formula1DashboardDbContext>
{
    public Formula1DashboardDbContext CreateDbContext(string[] args)
    {
        Formula1DashboardEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<Formula1DashboardDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new Formula1DashboardDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Formula1Dashboard.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
