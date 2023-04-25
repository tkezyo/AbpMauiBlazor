using Localization.Resources.AbpUi;
using AbpMauiBlazor.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace AbpMauiBlazor;

[DependsOn(
    typeof(AbpMauiBlazorApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class AbpMauiBlazorHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(AbpMauiBlazorHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<AbpMauiBlazorResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
