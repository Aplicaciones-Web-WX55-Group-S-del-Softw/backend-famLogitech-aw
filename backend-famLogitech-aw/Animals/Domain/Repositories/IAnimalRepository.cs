using backend_famLogitech_aw.Animals.Domain.Model.Aggregates;

namespace backend_famLogitech_aw.Animals.Domain.Repositories;

public interface IAnimalRepository
{
    Task<IEnumerable<Animal>> FindByAllAnimalsAsync();
    Task<Animal> FindByShedId(int shedId);
}