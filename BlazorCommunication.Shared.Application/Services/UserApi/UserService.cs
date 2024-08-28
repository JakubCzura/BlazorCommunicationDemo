using BlazorCommunication.Shared.Application.Services.UserApi.Interfaces;
using System.Net.Http.Json;
using UserApi.Application.ViewModels;

namespace BlazorCommunication.Shared.Application.Services.UserApi;

internal class UserService(HttpClient httpClient) : IUserService
{
    public async Task<UserViewModel> GetUserInfoAsync()
       => (await httpClient.GetFromJsonAsync<UserViewModel>("user-api/user/info"))!;
}