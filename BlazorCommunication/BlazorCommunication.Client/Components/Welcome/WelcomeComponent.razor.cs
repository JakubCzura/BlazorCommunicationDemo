﻿using Microsoft.AspNetCore.Components;
using Shared.ViewModels.UserApi;
using System.Net.Http.Json;

namespace BlazorCommunication.Client.Components.Welcome;

public partial class WelcomeComponent
{
    [Inject]
    public HttpClient HttpClient { get; set; } = default!;

    private UserViewModel User { get; set; } = new UserViewModel();

    protected override async Task OnInitializedAsync()
        => User = (await HttpClient.GetFromJsonAsync<UserViewModel>("user-api/user/info"))!;
}