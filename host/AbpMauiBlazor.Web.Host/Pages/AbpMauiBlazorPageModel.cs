using AbpMauiBlazor.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AbpMauiBlazor.Pages;

public abstract class AbpMauiBlazorPageModel : AbpPageModel
{
    protected AbpMauiBlazorPageModel()
    {
        LocalizationResourceType = typeof(AbpMauiBlazorResource);
    }
}
