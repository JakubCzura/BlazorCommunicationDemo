using BlazorCommunication.Shared.Application.Services.UserApi;
using BlazorCommunication.Shared.Application.Services.UserApi.Interfaces;
using BlazorCommunication.Shared.Application.Services.WeatherApi;
using BlazorCommunication.Shared.Application.Services.WeatherApi.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorCommunication.Shared.Application.ExtensionMethods;

public static class ApplicationRegistration
{
    public static IServiceCollection AddApplicationDI(this IServiceCollection services)
    {
        services.AddScoped<IWeatherForecastService, WeatherForecastService>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IMessageService, MessageService>();

        return services;
    }
}