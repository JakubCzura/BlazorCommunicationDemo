using BlazorCommunication.Shared.Application.Services.WeatherApi.Interfaces;
using Microsoft.AspNetCore.Components;
using WeatherApi.Application.ViewModels;

namespace BlazorCommunication.Client.Components.WeatherForecast;

public partial class WeatherForecastComponent
{
    [Inject]
    public IWeatherForecastService WeatherForecastService { get; set; } = default!;

    private WeatherForecastViewModel Forecast { get; set; } = new();

    protected override async Task OnInitializedAsync()
        => Forecast = await WeatherForecastService.GetWeatherForecastAsync();
}