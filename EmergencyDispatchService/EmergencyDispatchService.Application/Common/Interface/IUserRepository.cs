using EmergencyDispatchService.Domain.Users;

namespace EmergencyDispatchService.Application.Common.Interface;

public interface IUserRepository
{
    Task AddUserAsync(User user);

    Task<User?> GetByIdUserAsync(Guid userId);
}