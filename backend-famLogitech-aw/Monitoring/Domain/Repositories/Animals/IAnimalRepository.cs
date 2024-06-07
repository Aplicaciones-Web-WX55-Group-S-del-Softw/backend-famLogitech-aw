using backend_famLogitech_aw.Animals.Domain.Model.Aggregates;
using backend_famLogitech_aw.Shared.Domain.Repositories;

namespace backend_famLogitech_aw.Animals.Domain.Repositories;

public interface IAnimalRepository : IBaseRepository<Animal>
{
    Task<IEnumerable<Animal>> FindByAllAnimalsAsync();
    Task<Animal> FindByShedId(int shedId);
    
    Task<Animal> FindByIdAsync(int id);
    Task DeleteAsync(Animal animal);
}