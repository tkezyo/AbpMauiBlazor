using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace AbpMauiBlazor;

[DependsOn(
    typeof(AbpMauiBlazorApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class AbpMauiBlazorHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(AbpMauiBlazorApplicationContractsModule).Assembly,
            AbpMauiBlazorRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<AbpMauiBlazorHttpApiClientModule>();
        });

    }
}
