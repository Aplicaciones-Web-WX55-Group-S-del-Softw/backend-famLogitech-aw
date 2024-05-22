using backend_famLogitech_aw.Farms.Domain.Model.Aggregates;
using backend_famLogitech_aw.Shared.Domain.Repositories;

namespace backend_famLogitech_aw.Farms.Domain.Repositories;

public interface IFarmRepository: IBaseRepository<Farm>
{

   
    Task<IEnumerable<Farm>> FindByLocationAsync(string location);
 
    Task<IEnumerable<Farm>> FindByAllFarmAsync();
    
   
    Task<Farm> FindByIdx(int id);
    Task<Farm> UpdateFarmByIdAsync(int Id,Farm farm);
}