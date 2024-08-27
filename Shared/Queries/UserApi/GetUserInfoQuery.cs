using MediatR;
using Shared.ViewModels.UserApi;

namespace Shared.Queries.UserApi;

public class GetUserInfoQuery : IRequest<UserViewModel>
{
}