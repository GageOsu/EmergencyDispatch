using EmergencyDispatchService.Application.Common.Interface;
using EmergencyDispatchService.Domain.Users;
using System.Runtime.CompilerServices;

namespace EmergencyDispatchService.Application.Users.Commands.CreateUser;

public class CreateUserCommand
{
    private readonly IUserRepository _userRepository;
     private readonly IUnitOfWork _unitOfWork;

    public CreateUserCommand(IUnitOfWork unitOfWork, IUserRepository userRepository)
    {
        _unitOfWork = unitOfWork;
        _userRepository = userRepository;
    }

    public async Task<Guid> Create(User user, CancellationToken cancellationToken)
    {
        if (user == null)
        {
            return Guid.Empty;
        }
        var newuser = new User(
            firstName: user.FirstName,
            lastName: user.LastName,
            phoneNumber: user.PhoneNumber
            );
        await _userRepository.AddUserAsync(newuser);
        await _unitOfWork.CommitChangesAsync();

        return user.Id;
    }
}
