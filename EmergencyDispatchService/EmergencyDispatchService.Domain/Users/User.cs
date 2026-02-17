using EmergencyDispatchService.Domain.Common;
using EmergencyDispatchService.Domain.Compaints;
using EmergencyDispatchService.Domain.Positions;

namespace EmergencyDispatchService.Domain.Users;

public class User : Entity
{
    public string FirstName { get; private set; } = null!;

    public string LastName { get; private set; } = null!;

    public string PhoneNumber { get; private set; } = null!;

    public Guid PositionId {  get; private set; }

    public Position Position { get; private set; }

    public List<Complaint> Complaints { get; private set; } = [];

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


    private User()
    {

    }
}
