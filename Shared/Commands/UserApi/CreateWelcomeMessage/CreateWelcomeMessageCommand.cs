using MediatR;
using Shared.ViewModels.UserApi;

namespace Shared.Commands.UserApi.CreateWelcomeMessage;

public class CreateWelcomeMessageCommand : IRequest<WelcomeMessageViewModel>
{
    public string Name { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;
}