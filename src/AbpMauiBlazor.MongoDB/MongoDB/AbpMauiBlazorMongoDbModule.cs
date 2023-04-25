using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;

namespace AbpMauiBlazor.MongoDB;

[DependsOn(
    typeof(AbpMauiBlazorDomainModule),
    typeof(AbpMongoDbModule)
    )]
public class AbpMauiBlazorMongoDbModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddMongoDbContext<AbpMauiBlazorMongoDbContext>(options =>
        {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
        });
    }
}
