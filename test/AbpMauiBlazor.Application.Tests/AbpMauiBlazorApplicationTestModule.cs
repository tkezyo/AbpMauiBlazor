using Volo.Abp.Modularity;

namespace AbpMauiBlazor;

[DependsOn(
    typeof(AbpMauiBlazorApplicationModule),
    typeof(AbpMauiBlazorDomainTestModule)
    )]
public class AbpMauiBlazorApplicationTestModule : AbpModule
{

}
