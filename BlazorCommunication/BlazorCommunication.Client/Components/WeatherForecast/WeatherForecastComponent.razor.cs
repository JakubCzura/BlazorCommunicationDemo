using Microsoft.AspNetCore.Components;
using Shared.ViewModels.WeatherApi;
using System.Net.Http.Json;

namespace BlazorCommunication.Client.Components.WeatherForecast;

public partial class WeatherForecastComponent
{
    [Inject]
    public HttpClient HttpClient { get; set; } = default!;

    private WeatherForecastViewModel[] Forecasts { get; set; } = [];

    protected override async Task OnInitializedAsync()
        => Forecasts = (await HttpClient.GetFromJsonAsync<WeatherForecastViewModel[]>("weather-api/weatherforecast"))!;
}