using Volo.Abp;
using Volo.Abp.MongoDB;

namespace AbpMauiBlazor.MongoDB;

public static class AbpMauiBlazorMongoDbContextExtensions
{
    public static void ConfigureAbpMauiBlazor(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
