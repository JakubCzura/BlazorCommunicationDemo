using BlazorCommunication.Shared.Application.Services.UserApi.Interfaces;
using System.Net.Http.Json;
using UserApi.Application.Commands.CreateWelcomeMessage;
using UserApi.Application.ViewModels;

namespace BlazorCommunication.Shared.Application.Services.UserApi;

internal class MessageService(HttpClient httpClient) : IMessageService
{
    public async Task<WelcomeMessageViewModel> CreateWelcomeMessageAsync(CreateWelcomeMessageCommand command)
    {
        HttpResponseMessage response = (await httpClient.PostAsJsonAsync("user-api/message/welcome", command))!;
        return (await response.Content.ReadFromJsonAsync<WelcomeMessageViewModel>())!;
    }
}