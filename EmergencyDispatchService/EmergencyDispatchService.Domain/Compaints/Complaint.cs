using EmergencyDispatchService.Domain.Common;
using EmergencyDispatchService.Domain.Positions;
using EmergencyDispatchService.Domain.Status;
using EmergencyDispatchService.Domain.Users;

namespace EmergencyDispatchService.Domain.Compaints;

public class Complaint : Entity
{
    public int ComplaintId { get; private set; }
    public Guid UserCreateId { get; private set; }
    public User UserCreated { get; private set; } = null!;

    public Guid PositionId { get; private set; }
    public Position PositionResponsible{ get; private set; }

    public StatusEnum Status { get; private set; } = StatusEnum.Created;
    public DateTime CreateDate { get; private set; } = DateTime.Now;
    public DateTime AcceptedDate { get; private set; }
    public DateTime CompletionDate { get; private set; }

    //TODO: Добавить возможность добавления Фотографии
    public string Description { get; private set; } = null!;


    private Complaint()
    {
        
    }

}
