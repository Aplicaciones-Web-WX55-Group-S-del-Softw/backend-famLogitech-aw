using backend_famLogitech_aw.Crops.Domain.Model.Aggregates;
using backend_famLogitech_aw.Shared.Domain.Repositories;

namespace backend_famLogitech_aw.Crops.Domain.Repositories;

public interface ICropRepository : IBaseRepository<Crop>
{
    Task<IEnumerable<Crop>> FindByAllCropAsync();

    Task<Crop> FindByIdx(int id); 
    
    Task DeleteAsync(Crop crop);
}