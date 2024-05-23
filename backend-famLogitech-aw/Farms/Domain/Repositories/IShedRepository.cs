using backend_famLogitech_aw.Farms.Domain.Model.Aggregates;
using backend_famLogitech_aw.Shared.Domain.Repositories;

namespace backend_famLogitech_aw.Farms.Domain.Repositories;

public interface IShedRepository: IBaseRepository<Shed>
{
    
    Task<IEnumerable<Shed>> FindByAllShedAsync();
    Task<Shed> FindShedById(int id);

}