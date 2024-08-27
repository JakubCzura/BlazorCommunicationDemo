using MediatR;
using Shared.Queries.UserApi;
using Shared.ViewModels.UserApi;

namespace UserApi.Application.Handlers.Queries.GetUserInfo;

public class GetUserInfoQueryHandler : IRequestHandler<GetUserInfoQuery, UserViewModel>
{
    public async Task<UserViewModel> Handle(GetUserInfoQuery request, 
                                            CancellationToken cancellationToken)
    {
        UserViewModel user = new()
        {
            Name = "John",
            LastName = "Kowalski",
            Age = 30
        };
        return await Task.FromResult(user);
    }
}