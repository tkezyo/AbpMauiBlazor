using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace AbpMauiBlazor.EntityFrameworkCore;

[ConnectionStringName(AbpMauiBlazorDbProperties.ConnectionStringName)]
public interface IAbpMauiBlazorDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
