using AbpMauiBlazor.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpMauiBlazor;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(AbpMauiBlazorEntityFrameworkCoreTestModule)
    )]
public class AbpMauiBlazorDomainTestModule : AbpModule
{

}
