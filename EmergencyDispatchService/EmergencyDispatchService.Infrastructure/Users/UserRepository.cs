using EmergencyDispatchService.Application.Common.Interface;
using EmergencyDispatchService.Domain.Users;
using EmergencyDispatchService.Infrastructure.Common;

namespace EmergencyDispatchService.Infrastructure.Users;

public class UserRepository : IUserRepository
{
    private readonly EmergencyDispatchServiceDbContext _context;

    public UserRepository(EmergencyDispatchServiceDbContext context)
    {
        _context = context;
    }

    public async Task AddUserAsync(User user)
    {
        await _context.Users.AddAsync(user);
    }

    public async Task<User?> GetByIdUserAsync(Guid userId)
    {
        return await _context.Users.FindAsync(userId);
    }
}
