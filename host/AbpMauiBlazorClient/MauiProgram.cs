using AbpMauiBlazorClient.Data;
using AbpMauiBlazorClient.WinUI;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;
using System.Reflection;
using Volo.Abp;
using Volo.Abp.Autofac;

namespace AbpMauiBlazorClient
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
                .ConfigureContainer(new AbpAutofacServiceProviderFactory(new Autofac.ContainerBuilder()));

            ConfigureConfiguration(builder);
            builder.Services.AddMauiBlazorWebView();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif
            builder.Services.AddApplication<AbpMauiBlazorClientModule>(options =>
            {
                options.Services.ReplaceConfiguration(builder.Configuration);
            });
            builder.Services.AddSingleton<WeatherForecastService>();

            var app = builder.Build();
            try
            {
                app.Services.GetRequiredService<IAbpApplicationWithExternalServiceProvider>().Initialize(app.Services);

            }
            catch (Exception e)
            {

                throw;
            }

            return app;
        }
        private static void ConfigureConfiguration(MauiAppBuilder builder)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;
            builder.Configuration.AddJsonFile(new EmbeddedFileProvider(assembly), "appsettings.json", optional: false, false);
        }
    }
}