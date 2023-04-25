using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace AbpMauiBlazor;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpMauiBlazorHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class AbpMauiBlazorConsoleApiClientModule : AbpModule
{

}
