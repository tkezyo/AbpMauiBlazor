using AbpMauiBlazor;
using Volo.Abp.AspNetCore.Components.MauiBlazor;
using Volo.Abp.AspNetCore.Components.MauiBlazor.Theming;
using Volo.Abp.Authorization;
using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel.MauiBlazor;
using Volo.Abp.Modularity;

namespace AbpMauiBlazorClient
{
    [DependsOn(
      typeof(AbpAutofacModule),
      typeof(AbpMauiBlazorHttpApiClientModule),
      typeof(AbpAspNetCoreComponentsMauiBlazorModule),
      typeof(AbpAspNetCoreComponentsMauiBlazorThemingModule),
      typeof(AbpHttpClientIdentityModelMauiBlazorModule))]
    public class AbpMauiBlazorClientModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            base.ConfigureServices(context);
            //context.Services.AddOidcAuthentication(options =>
            //{
            //    builder.Configuration.Bind("AuthServer", options.ProviderOptions);
            //    options.ProviderOptions.DefaultScopes.Add("AbpMauiBlazor");
            //});
        }
    }
}
