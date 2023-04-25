using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpMauiBlazor.Blazor.Server.Host;

[Dependency(ReplaceServices = true)]
public class AbpMauiBlazorBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AbpMauiBlazor";
}
