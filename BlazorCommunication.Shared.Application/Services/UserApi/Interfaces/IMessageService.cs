using Shared.Commands.UserApi.CreateWelcomeMessage;
using Shared.ViewModels.UserApi;

namespace BlazorCommunication.Shared.Application.Services.UserApi.Interfaces;

public interface IMessageService
{
    Task<WelcomeMessageViewModel> CreateWelcomeMessageAsync(CreateWelcomeMessageCommand command);
}