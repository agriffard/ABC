namespace Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static void ConfigureAppSettingsSection(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<AppSettings>(configuration.GetSection(ConfigurationConstants.AppSettingsSectionName));
    }
}
