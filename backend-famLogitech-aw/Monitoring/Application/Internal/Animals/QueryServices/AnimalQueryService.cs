using backend_famLogitech_aw.Animals.Domain.Model.Aggregates;
using backend_famLogitech_aw.Animals.Domain.Model.Queries;
using backend_famLogitech_aw.Animals.Domain.Repositories;
using backend_famLogitech_aw.Animals.Domain.Services;

namespace backend_famLogitech_aw.Animals.Application.Internal.QueryServices;

public class AnimalQueryService : IAnimalQueryService
{
    private IAnimalRepository _animalRepository;
    
    public async Task<Animal> Handle(GetAnimalByIdQuery query)
    {
        return await _animalRepository.FindByIdAsync(query.Id);
    }

    public async Task<IEnumerable<Animal>> Handle(GetAllAnimalsQuery query)
    {
        return await _animalRepository.FindByAllAnimalsAsync();
    }

    public async Task<Animal> Handle(GetAnimalByShedIdQuery query)
    {
        return await _animalRepository.FindByIdAsync(query.ShedId); 
    }
}