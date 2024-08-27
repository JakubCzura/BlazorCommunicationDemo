using Microsoft.AspNetCore.Components;
using Shared.ViewModels.UserApi;
using System.Net.Http.Json;

namespace BlazorCommunication.Client.Components.Welcome;

public partial class WelcomeComponent
{
    [Inject]
    public HttpClient HttpClient { get; set; } = default!;

    [Parameter]
    public string Name { get; set; } = string.Empty;

    private MessageViewModel Message { get; set; } = new();

    protected override async Task OnInitializedAsync()
    {
        HttpResponseMessage response = await HttpClient.PostAsJsonAsync($"user-api/message/welcome?name={Name}", "");
        response.EnsureSuccessStatusCode();
        Message = (await response.Content.ReadFromJsonAsync<MessageViewModel>())!;
    }
}