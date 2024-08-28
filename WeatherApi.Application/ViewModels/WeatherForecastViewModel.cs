using WeatherApi.Application.Dtos;

namespace WeatherApi.Application.ViewModels;

public class WeatherForecastViewModel
{
    public List<WeatherForecastDto> WeatherForecasts { get; set; } = [];
}