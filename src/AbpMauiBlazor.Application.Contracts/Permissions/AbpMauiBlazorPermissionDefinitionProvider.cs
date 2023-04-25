using AbpMauiBlazor.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpMauiBlazor.Permissions;

public class AbpMauiBlazorPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AbpMauiBlazorPermissions.GroupName, L("Permission:AbpMauiBlazor"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AbpMauiBlazorResource>(name);
    }
}
