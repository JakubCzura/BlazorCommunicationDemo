using MediatR;
using UserApi.Application.ViewModels;

namespace UserApi.Application.Commands.CreateWelcomeMessage;

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