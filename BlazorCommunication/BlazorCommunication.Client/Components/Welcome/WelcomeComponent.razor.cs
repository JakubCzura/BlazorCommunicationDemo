using BlazorCommunication.Shared.Application.Services.UserApi.Interfaces;
using Microsoft.AspNetCore.Components;
using UserApi.Application.Commands.CreateWelcomeMessage;
using UserApi.Application.ViewModels;

namespace BlazorCommunication.Client.Components.Welcome;

public partial class WelcomeComponent
{
    [Inject]
    public IMessageService MessageService { get; set; } = default!;

    [Parameter]
    public string Name { get; set; } = string.Empty;

    [Parameter]
    public string LastName { get; set; } = string.Empty;

    private WelcomeMessageViewModel Message { get; set; } = new();

    protected override async Task OnInitializedAsync()
        => Message = await MessageService.CreateWelcomeMessageAsync(new CreateWelcomeMessageCommand { Name = Name, LastName = LastName });
}