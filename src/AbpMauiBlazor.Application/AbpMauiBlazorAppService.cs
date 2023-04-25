using AbpMauiBlazor.Localization;
using Volo.Abp.Application.Services;

namespace AbpMauiBlazor;

public abstract class AbpMauiBlazorAppService : ApplicationService
{
    protected AbpMauiBlazorAppService()
    {
        LocalizationResource = typeof(AbpMauiBlazorResource);
        ObjectMapperContext = typeof(AbpMauiBlazorApplicationModule);
    }
}
