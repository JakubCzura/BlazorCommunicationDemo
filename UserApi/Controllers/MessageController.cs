using Microsoft.AspNetCore.Mvc;
using Shared.ViewModels.UserApi;

namespace UserApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MessageController(ILogger<MessageController> logger) : ControllerBase
{
    [HttpPost("Welcome")]
    public ActionResult<UserViewModel> GetWelcomeMessage([FromQuery] string Name)
    {
        logger.LogWarning("HtppGet - api/Message/Welcome called");

        MessageViewModel message = new()
        {
            Message = $"Hello {Name}, we are so excited that you use our website."
        };
        return Ok(message);
    }
}