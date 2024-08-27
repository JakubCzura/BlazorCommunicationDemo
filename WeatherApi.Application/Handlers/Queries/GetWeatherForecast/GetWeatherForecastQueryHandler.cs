using MediatR;
using Shared.Dtos.WeatherApi;
using Shared.Queries.WeatherApi.GetWeatherForecast;
using Shared.ViewModels.WeatherApi;

namespace WeatherApi.Application.Handlers.Queries.GetWeatherForecast;

public class GetWeatherForecastQueryHandler : IRequestHandler<GetWeatherForecastQuery, WeatherForecastViewModel>
{
    public Task<WeatherForecastViewModel> Handle(GetWeatherForecastQuery request,
                                                 CancellationToken cancellationToken)
    {
        string[] summaries =
        [
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        ];

        WeatherForecastViewModel weatherForecastViewModel = new()
        {
            WeatherForecasts = Enumerable.Range(1, 5).Select(index => new WeatherForecastDto
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = summaries[Random.Shared.Next(summaries.Length)]
            }).ToList()
        };

        return Task.FromResult(weatherForecastViewModel);
    }
}