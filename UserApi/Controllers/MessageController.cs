using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shared.Commands.UserApi.CreateWelcomeMessage;
using Shared.ViewModels.UserApi;

namespace UserApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MessageController(ILogger<MessageController> logger,
                               IMediator mediator) : ControllerBase
{
    [HttpPost("Welcome")]
    public async Task<ActionResult<UserViewModel>> GetWelcomeMessage([FromBody] CreateWelcomeMessageCommand command)
    {
        logger.LogWarning("HtppGet - api/Message/Welcome called");

        WelcomeMessageViewModel message = await mediator.Send(command);
        return Ok(message);
    }
}