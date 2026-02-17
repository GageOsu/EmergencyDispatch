using EmergencyDispatchService.Domain.Common;

namespace EmergencyDispatchService.Domain.Compaints;

public class Complaint : Entity
{
    public int ComplaintId { get; private set; }
    public Guid UserCreateId { get; private set; } 

    //TODO: Сделать enum статуса жалобы

    public DateTime CreateDate { get; private set; }

    public DateTime AcceptedDate { get; private set; }
    public DateTime CompletionDate { get; private set; }

    //TODO: Добавить возможность добавления Фотографии
    public string Description { get; private set; } = null!;




}
