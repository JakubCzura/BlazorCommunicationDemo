using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace WeatherApi.Application.ExtensionMethods;

public static class ApplicationRegistration
{
    public static IServiceCollection AddApplicationDI(this IServiceCollection services)
    {
        services.AddMediatR(config =>
        {
            config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
        });

        return services;
    }
}