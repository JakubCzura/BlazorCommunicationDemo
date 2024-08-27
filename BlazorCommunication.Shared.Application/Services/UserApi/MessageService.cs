using BlazorCommunication.Shared.Application.Services.UserApi.Interfaces;
using Shared.Commands.UserApi.CreateWelcomeMessage;
using Shared.ViewModels.UserApi;
using System.Net.Http.Json;

namespace BlazorCommunication.Shared.Application.Services.UserApi;

internal class MessageService(HttpClient httpClient) : IMessageService
{
    public async Task<WelcomeMessageViewModel> CreateWelcomeMessageAsync(CreateWelcomeMessageCommand command)
    {
        HttpResponseMessage response = (await httpClient.PostAsJsonAsync("user-api/message/welcome", command))!;
        response.EnsureSuccessStatusCode();
        return (await response.Content.ReadFromJsonAsync<WelcomeMessageViewModel>())!;
    }
}