using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace AbpMauiBlazor.EntityFrameworkCore;

public class AbpMauiBlazorHttpApiHostMigrationsDbContext : AbpDbContext<AbpMauiBlazorHttpApiHostMigrationsDbContext>
{
    public AbpMauiBlazorHttpApiHostMigrationsDbContext(DbContextOptions<AbpMauiBlazorHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureAbpMauiBlazor();
    }
}
