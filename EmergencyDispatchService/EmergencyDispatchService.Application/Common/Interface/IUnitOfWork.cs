namespace EmergencyDispatchService.Application.Common.Interface;

public interface IUnitOfWork
{
    Task CommitChangesAsync();
}