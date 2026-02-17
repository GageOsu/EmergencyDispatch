using EmergencyDispatchService.Domain.Common;
using EmergencyDispatchService.Domain.Compaints;
using EmergencyDispatchService.Domain.Users;

namespace EmergencyDispatchService.Domain.Positions;

public class Position : Entity
{
    public Guid PositionId { get; private set; }
    public string PositionName { get; private set; } = null!;

    public User User { get; private set; }

    public Complaint Complaint { get; private set; }

    public Position(
        string positionName,
        Guid? id = null)
        : base(id ??  Guid.NewGuid())
    {
        PositionName = positionName;
    }

    private Position()
    {
        
    }

}