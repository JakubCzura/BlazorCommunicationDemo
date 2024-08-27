using Shared.ViewModels.WeatherApi;

namespace BlazorCommunication.Shared.Application.Services.WeatherApi.Interfaces;

public interface IWeatherForecastService
{
    Task<WeatherForecastViewModel> GetWeatherForecastAsync();
}