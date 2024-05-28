using backend_famLogitech_aw.Farms.Domain.Model.Aggregates;
using backend_famLogitech_aw.profiles.Domain.Model.Aggregates;
using backend_famLogitech_aw.Shared.Domain.Repositories;

namespace backend_famLogitech_aw.profiles.Domain.Repositories;

public interface IUserRepository : IBaseRepository<User>
{
    Task<User> FindByUser(int id);
    Task<IEnumerable<User>> FindByAllUserAsync();

    
    
}