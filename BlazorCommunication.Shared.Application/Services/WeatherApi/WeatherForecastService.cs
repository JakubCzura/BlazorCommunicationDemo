using BlazorCommunication.Shared.Application.Services.WeatherApi.Interfaces;
using Shared.ViewModels.WeatherApi;
using System.Net.Http.Json;

namespace BlazorCommunication.Shared.Application.Services.WeatherApi;

internal class WeatherForecastService(HttpClient httpClient) : IWeatherForecastService
{
    public async Task<WeatherForecastViewModel> GetWeatherForecastAsync()
        => (await httpClient.GetFromJsonAsync<WeatherForecastViewModel>("weather-api/weatherforecast"))!;
}