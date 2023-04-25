using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace AbpMauiBlazor;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class AbpMauiBlazorInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<AbpMauiBlazorInstallerModule>();
        });
    }
}
