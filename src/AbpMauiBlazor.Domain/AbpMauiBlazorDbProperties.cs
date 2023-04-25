namespace AbpMauiBlazor;

public static class AbpMauiBlazorDbProperties
{
    public static string DbTablePrefix { get; set; } = "AbpMauiBlazor";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "AbpMauiBlazor";
}
