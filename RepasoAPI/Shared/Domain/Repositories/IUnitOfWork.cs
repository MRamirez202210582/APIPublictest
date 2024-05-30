namespace RepasoAPI.Shared.Domain.Repositories;

public interface IUnitOfWork
{
    Task CompleteAsync();
}