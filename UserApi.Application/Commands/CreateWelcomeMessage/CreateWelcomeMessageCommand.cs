using MediatR;
using UserApi.Application.ViewModels;

namespace UserApi.Application.Commands.CreateWelcomeMessage;

public class CreateWelcomeMessageCommand : IRequest<WelcomeMessageViewModel>
{
    public string Name { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;
}