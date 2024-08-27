using MediatR;
using Shared.Commands.UserApi.CreateWelcomeMessage;
using Shared.ViewModels.UserApi;

namespace UserApi.Application.Handlers.Commands.CreateWelcomeMessage;

public class CreateWelcomeMessageCommandHandler : IRequestHandler<CreateWelcomeMessageCommand, WelcomeMessageViewModel>
{
    public async Task<WelcomeMessageViewModel> Handle(CreateWelcomeMessageCommand request,
                                                      CancellationToken cancellationToken)
    {
        WelcomeMessageViewModel welcomeMessage = new()
        {
            Message = $"Hello {request.Name} {request.LastName}! We are excited that you use our website."
        };

        return await Task.FromResult(welcomeMessage);
    }
}