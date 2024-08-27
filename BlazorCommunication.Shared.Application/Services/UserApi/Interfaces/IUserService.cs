using Shared.ViewModels.UserApi;

namespace BlazorCommunication.Shared.Application.Services.UserApi.Interfaces;

public interface IUserService
{
    Task<UserViewModel> GetUserInfoAsync();
}