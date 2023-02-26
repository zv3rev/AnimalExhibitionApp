namespace AnimalExhibition.Api;

using AnimalExhibition.Api.Settings;
using AnimalExhibition.Services.Settings;
using Microsoft.Extensions.DependencyInjection;

public static class Bootstrapper
{
    public static IServiceCollection RegisterAppServices(this IServiceCollection services)
    {
        services
            .AddMainSettings()
            .AddSwaggerSettings()
            .AddIdentitySettings()
            .AddApiSpecialSettings()
            ;

        return services;
    }
}
