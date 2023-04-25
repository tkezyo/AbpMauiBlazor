using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace AbpMauiBlazor.Pages;

public class IndexModel : AbpMauiBlazorPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
