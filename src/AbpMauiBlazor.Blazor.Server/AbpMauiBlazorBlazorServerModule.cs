using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace AbpMauiBlazor.Blazor.Server;

[DependsOn(
    typeof(AbpAspNetCoreComponentsServerThemingModule),
    typeof(AbpMauiBlazorBlazorModule)
    )]
public class AbpMauiBlazorBlazorServerModule : AbpModule
{

}
