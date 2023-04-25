using AbpMauiBlazor.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AbpMauiBlazor.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class AbpMauiBlazorPageModel : AbpPageModel
{
    protected AbpMauiBlazorPageModel()
    {
        LocalizationResourceType = typeof(AbpMauiBlazorResource);
        ObjectMapperContext = typeof(AbpMauiBlazorWebModule);
    }
}
