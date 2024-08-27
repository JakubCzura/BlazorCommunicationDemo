using BlazorCommunication.Shared.Application.Services.UserApi.Interfaces;
using Microsoft.AspNetCore.Components;
using Shared.ViewModels.UserApi;

namespace BlazorCommunication.Client.Components.UserInfo;

public partial class UserInfoComponent
{
    [Inject]
    public IUserService UserService { get; set; } = default!;

    private UserViewModel User { get; set; } = new UserViewModel();

    protected override async Task OnInitializedAsync()
        => User = await UserService.GetUserInfoAsync();
}