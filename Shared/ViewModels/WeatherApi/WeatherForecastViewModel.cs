using Shared.Dtos.WeatherApi;

namespace Shared.ViewModels.WeatherApi;

public class WeatherForecastViewModel
{
    public List<WeatherForecastDto> WeatherForecasts { get; set; } = [];
}