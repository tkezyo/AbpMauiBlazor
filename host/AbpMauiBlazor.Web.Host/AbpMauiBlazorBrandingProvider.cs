using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace AbpMauiBlazor;

[Dependency(ReplaceServices = true)]
public class AbpMauiBlazorBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AbpMauiBlazor";
}
