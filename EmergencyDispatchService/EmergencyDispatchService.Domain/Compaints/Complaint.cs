using EmergencyDispatchService.Domain.Common;

namespace EmergencyDispatchService.Domain.Compaints;

public class Complaint : Entity
{
    public Guid UserCreateId { get; } 

    public Guid UserAcceptId { get; }

    //TODO: Сделать enum статуса жалобы

    public DateTime CreateDate { get; }

    public DateTime CompletionDate { get; }


    //TODO: Добавить возможность добавления Фотографии
    public string Description { get; } = null!;




}
