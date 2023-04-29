using AbpMauiBlazor;
using AbpMauiBlazorClient.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Text;
using Volo.Abp.AspNetCore.Components.MauiBlazor;
using Volo.Abp.AspNetCore.Components.MauiBlazor.Theming;
using Volo.Abp.AspNetCore.Mvc.Client;
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
      typeof(AbpAspNetCoreMvcClientCommonModule),
      typeof(AbpHttpClientIdentityModelMauiBlazorModule))]
    public class AbpMauiBlazorClientModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            base.ConfigureServices(context);
            context.Services.AddScoped<AuthenticationStateProvider, AuthProvider>();
            context.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,//是否验证Issuer
                        ValidateAudience = true,//是否验证Audience
                        ValidateLifetime = true,//是否验证失效时间
                        ValidateIssuerSigningKey = true,//是否验证SecurityKey
                        ValidAudience = "guetClient",//Audience
                        ValidIssuer = "guetServer",//Issuer，这两项和签发jwt的设置一致
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("123456789012345678901234567890123456789"))//拿到SecurityKey
                    };
                });
            //context.Services.AddOidcAuthentication(options =>
            //{
            //    builder.Configuration.Bind("AuthServer", options.ProviderOptions);
            //    options.UserOptions.NameClaim = OpenIddictConstants.Claims.Name;
            //    options.UserOptions.RoleClaim = OpenIddictConstants.Claims.Role;

            //    options.ProviderOptions.DefaultScopes.Add("Wpf");
            //    options.ProviderOptions.DefaultScopes.Add("roles");
            //    options.ProviderOptions.DefaultScopes.Add("email");
            //    options.ProviderOptions.DefaultScopes.Add("phone");
            //});

            context.Services.AddTransient(sp => new HttpClient
            {
                BaseAddress = new Uri("http://localhost:8055")
            });
            //context.Services.AddOidcAuthentication(options =>
            //{
            //    builder.Configuration.Bind("AuthServer", options.ProviderOptions);
            //    options.ProviderOptions.DefaultScopes.Add("AbpMauiBlazor");
            //});
        }
    }
}
