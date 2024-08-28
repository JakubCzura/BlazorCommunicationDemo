using MediatR;
using Shared.ViewModels.UserApi;

namespace Shared.Queries.UserApi.GetUserInfo;

public class GetUserInfoQuery : IRequest<UserViewModel>
{
}