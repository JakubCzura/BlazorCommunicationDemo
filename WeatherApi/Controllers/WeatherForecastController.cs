using MediatR;
using Microsoft.AspNetCore.Mvc;
using WeatherApi.Application.Queries.GetWeatherForecast;
using WeatherApi.Application.ViewModels;

namespace WeatherApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController(ILogger<WeatherForecastController> logger,
                                       IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<WeatherForecastViewModel>> Get()
    {
        logger.LogWarning("HtppGet - api/WeatherForecast called");

        WeatherForecastViewModel result = await mediator.Send(new GetWeatherForecastQuery());

        return Ok(result);
    }
}