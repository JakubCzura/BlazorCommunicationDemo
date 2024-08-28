using BlazorCommunication.Shared.Application.Services.WeatherApi.Interfaces;
using System.Net.Http.Json;
using WeatherApi.Application.ViewModels;

namespace BlazorCommunication.Shared.Application.Services.WeatherApi;

internal class WeatherForecastService(HttpClient httpClient) : IWeatherForecastService
{
    public async Task<WeatherForecastViewModel> GetWeatherForecastAsync()
        => (await httpClient.GetFromJsonAsync<WeatherForecastViewModel>("weather-api/weatherforecast"))!;
}