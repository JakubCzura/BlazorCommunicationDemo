using BlazorCommunication.Shared.Application.Services.UserApi.Interfaces;
using Shared.ViewModels.UserApi;
using System.Net.Http.Json;

namespace BlazorCommunication.Shared.Application.Services.UserApi;

internal class UserService(HttpClient httpClient) : IUserService
{
    public async Task<UserViewModel> GetUserInfoAsync()
       => (await httpClient.GetFromJsonAsync<UserViewModel>("user-api/user/info"))!;
}