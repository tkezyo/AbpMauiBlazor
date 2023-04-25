using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace AbpMauiBlazor.MongoDB;

[ConnectionStringName(AbpMauiBlazorDbProperties.ConnectionStringName)]
public interface IAbpMauiBlazorMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
