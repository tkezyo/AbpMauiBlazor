using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpMauiBlazor.EntityFrameworkCore;

[DependsOn(
    typeof(AbpMauiBlazorDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class AbpMauiBlazorEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<AbpMauiBlazorDbContext>(options =>
        {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
        });
    }
}
