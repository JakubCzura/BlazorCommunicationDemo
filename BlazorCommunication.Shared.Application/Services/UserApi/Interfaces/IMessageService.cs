using UserApi.Application.Commands.CreateWelcomeMessage;
using UserApi.Application.ViewModels;

namespace BlazorCommunication.Shared.Application.Services.UserApi.Interfaces;

public interface IMessageService
{
    Task<WelcomeMessageViewModel> CreateWelcomeMessageAsync(CreateWelcomeMessageCommand command);
}