using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace AbpMauiBlazor;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(AbpMauiBlazorDomainSharedModule)
)]
public class AbpMauiBlazorDomainModule : AbpModule
{

}
