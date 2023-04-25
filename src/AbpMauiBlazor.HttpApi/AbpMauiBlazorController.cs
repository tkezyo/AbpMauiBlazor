using AbpMauiBlazor.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpMauiBlazor;

public abstract class AbpMauiBlazorController : AbpControllerBase
{
    protected AbpMauiBlazorController()
    {
        LocalizationResource = typeof(AbpMauiBlazorResource);
    }
}
