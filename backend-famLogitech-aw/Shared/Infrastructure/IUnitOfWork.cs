namespace backend_famLogitech_aw.Shared.Infrastructure;

public interface IUnitOfWork
{
    Task CompleteAsync();
}