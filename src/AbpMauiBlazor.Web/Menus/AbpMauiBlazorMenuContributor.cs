using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace AbpMauiBlazor.Web.Menus;

public class AbpMauiBlazorMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(AbpMauiBlazorMenus.Prefix, displayName: "AbpMauiBlazor", "~/AbpMauiBlazor", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
