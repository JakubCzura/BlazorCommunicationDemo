using Microsoft.AspNetCore.Mvc;
using Shared.ViewModels.UserApi;

namespace UserApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController(ILogger<UserController> logger) : ControllerBase
{
    [HttpGet("Info")]
    public ActionResult<UserViewModel> Get()
    {
        logger.LogWarning("HtppGet - User-Info called");

        UserViewModel user = new()
        {
            Name = "John",
            LastName = "Kowalski",
            Age = 30
        };
        return Ok(user);
    }
}
