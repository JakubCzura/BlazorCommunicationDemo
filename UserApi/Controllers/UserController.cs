using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shared.Queries.UserApi;
using Shared.ViewModels.UserApi;

namespace UserApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController(ILogger<UserController> logger,
                            IMediator mediator) : ControllerBase
{
    [HttpGet("Info")]
    public async Task<ActionResult<UserViewModel>> GetInfo()
    {
        logger.LogWarning("HtppGet - api/User/Info called");

        UserViewModel user = await mediator.Send(new GetUserInfoQuery());
        return Ok(user);
    }
}