using MediatR;
using UserApi.Application.ViewModels;

namespace UserApi.Application.Queries.GetUserInfo;

public class GetUserInfoQuery : IRequest<UserViewModel>
{
}