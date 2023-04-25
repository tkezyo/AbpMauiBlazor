using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace AbpMauiBlazor.Blazor.WebAssembly;

[DependsOn(
    typeof(AbpMauiBlazorBlazorModule),
    typeof(AbpMauiBlazorHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class AbpMauiBlazorBlazorWebAssemblyModule : AbpModule
{

}
