using AbpMauiBlazor.Localization;
using Volo.Abp.AspNetCore.Components;

namespace AbpMauiBlazor.Blazor.Server.Host;

public abstract class AbpMauiBlazorComponentBase : AbpComponentBase
{
    protected AbpMauiBlazorComponentBase()
    {
        LocalizationResource = typeof(AbpMauiBlazorResource);
    }
}
