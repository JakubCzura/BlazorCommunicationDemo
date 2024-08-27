using Microsoft.AspNetCore.Mvc;
using Shared.ViewModels.WeatherApi;

namespace WeatherApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController(ILogger<WeatherForecastController> logger) : ControllerBase
{
    private static readonly string[] Summaries =
    [
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    ];

    [HttpGet]
    public ActionResult<IEnumerable<WeatherForecastViewModel>> Get()
    {
        logger.LogWarning("HtppGet - api/WeatherForecast called");

        WeatherForecastViewModel[] result = Enumerable.Range(1, 5)
                                                      .Select(index => new WeatherForecastViewModel
                                                      {
                                                          Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                                                          TemperatureC = Random.Shared.Next(-20, 55),
                                                          Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                                                      })
                                                      .ToArray();

        return Ok(result);
    }
}