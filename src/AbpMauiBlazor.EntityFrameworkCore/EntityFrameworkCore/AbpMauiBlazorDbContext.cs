using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace AbpMauiBlazor.EntityFrameworkCore;

[ConnectionStringName(AbpMauiBlazorDbProperties.ConnectionStringName)]
public class AbpMauiBlazorDbContext : AbpDbContext<AbpMauiBlazorDbContext>, IAbpMauiBlazorDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public AbpMauiBlazorDbContext(DbContextOptions<AbpMauiBlazorDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureAbpMauiBlazor();
    }
}
