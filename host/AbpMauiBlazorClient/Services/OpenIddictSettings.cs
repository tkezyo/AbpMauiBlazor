using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpMauiBlazorClient.Services
{
    public class OpenIddictSettings
    {
        public string AuthorityUrl { get; set; }
        public string ClientId { get; set; }
        public string RedirectUri { get; set; }
        public string Scope { get; set; }
        public string ClientSecret { get; set; }
        public string PostLogoutRedirectUri { get; set; }
    }
    public static class OidcConsts
    {
        internal const string AccessTokenKeyName = "__access_token";
        internal const string RefreshTokenKeyName = "__refresh_token";
    }

}
