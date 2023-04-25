using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AbpMauiBlazor.EntityFrameworkCore;

public class AbpMauiBlazorHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<AbpMauiBlazorHttpApiHostMigrationsDbContext>
{
    public AbpMauiBlazorHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<AbpMauiBlazorHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("AbpMauiBlazor"));

        return new AbpMauiBlazorHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
