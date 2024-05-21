using backend_famLogitech_aw.Farms.Domain.Model.Aggregates;
using backend_famLogitech_aw.Shared.Domain.Repositories;

namespace backend_famLogitech_aw.Farms.Domain.Repositories;

public interface IFarmRepository: IBaseRepository<Farm>
{
    //TODO ROD
    Task<IEnumerable<Farm>> FindByLocationAsync(string location);
    Task<Farm> FindById(int id);
}