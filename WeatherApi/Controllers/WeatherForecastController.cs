using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shared.Queries.WeatherApi.GetWeatherForecast;
using Shared.ViewModels.WeatherApi;

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