using MediatR;
using WeatherApi.Application.ViewModels;

namespace WeatherApi.Application.Queries.GetWeatherForecast;

public class GetWeatherForecastQuery : IRequest<WeatherForecastViewModel>
{
}