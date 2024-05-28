using backend_famLogitech_aw.Farms.Domain.Repositories;
using backend_famLogitech_aw.Farms.Domain.Services;
using backend_famLogitech_aw.profiles.Domain.Model.Aggregates;
using backend_famLogitech_aw.profiles.Domain.Model.Commands;
using backend_famLogitech_aw.profiles.Domain.Repositories;
using backend_famLogitech_aw.Shared.Domain.Repositories;

namespace backend_famLogitech_aw.profiles.Application.Internal.CommandServices;

public class UserCommandService (IUnitOfWork unitOfWork, IUserRepository UserRepository) : IUserRepository
{
    public Task AddAsync(User entity)
    {
        throw new NotImplementedException();
    }

    public Task<User> FindByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<User> FindByUser(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<User>> FindByAllUserAsync()
    {
        throw new NotImplementedException();
    }
}