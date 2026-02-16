using EmergencyDispatchService.Domain.Common;

namespace EmergencyDispatchService.Domain.Users;

public class User : Entity
{
    public string FirstName { get; } = null!;

    public string LastName { get; } = null!;

    public string PhoneNumber { get; } = null!;

    public User(
        string firstName,
        string lastName,
        string phoneNumber,
        Guid? id = null)
        : base(id ?? Guid.NewGuid())
    {
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
    }

    //TODO: Добавить хэш пароль
}
