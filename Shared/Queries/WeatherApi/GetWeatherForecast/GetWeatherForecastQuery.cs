using MediatR;
using Shared.ViewModels.WeatherApi;

namespace Shared.Queries.WeatherApi.GetWeatherForecast;

public class GetWeatherForecastQuery : IRequest<WeatherForecastViewModel>
{
}