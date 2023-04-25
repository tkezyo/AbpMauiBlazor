using Volo.Abp.Reflection;

namespace AbpMauiBlazor.Permissions;

public class AbpMauiBlazorPermissions
{
    public const string GroupName = "AbpMauiBlazor";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(AbpMauiBlazorPermissions));
    }
}
