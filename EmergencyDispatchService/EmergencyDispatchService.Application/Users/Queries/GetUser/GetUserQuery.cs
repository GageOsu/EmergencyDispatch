using EmergencyDispatchService.Application.Common.Interface;
using EmergencyDispatchService.Domain.Users;

namespace EmergencyDispatchService.Application.Users.Queries.GetUser;

public class GetUserQuery
{
    private readonly IUserRepository _userRepository;

    public GetUserQuery(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<User?> GetById(Guid id, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetByIdUserAsync(id);

        return user is null 
            ? null 
            : user;
    }
}
