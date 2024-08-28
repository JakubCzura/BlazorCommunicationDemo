using WeatherApi.Application.ViewModels;

namespace BlazorCommunication.Shared.Application.Services.WeatherApi.Interfaces;

public interface IWeatherForecastService
{
    Task<WeatherForecastViewModel> GetWeatherForecastAsync();
}