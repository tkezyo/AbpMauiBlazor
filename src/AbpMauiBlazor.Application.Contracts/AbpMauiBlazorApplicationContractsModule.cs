using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace AbpMauiBlazor;

[DependsOn(
    typeof(AbpMauiBlazorDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class AbpMauiBlazorApplicationContractsModule : AbpModule
{

}
