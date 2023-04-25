using Volo.Abp.Bundling;

namespace AbpMauiBlazor.Blazor.Host;

public class AbpMauiBlazorBlazorHostBundleContributor : IBundleContributor
{
    public void AddScripts(BundleContext context)
    {

    }

    public void AddStyles(BundleContext context)
    {
        context.Add("main.css", true);
    }
}
