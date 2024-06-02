using backend_famLogitech_aw.Animals.Domain.Model.Aggregates;
using backend_famLogitech_aw.Animals.Domain.Model.Queries;

namespace backend_famLogitech_aw.Animals.Domain.Services;

public interface IAnimalQueryService
{
    Task <Animal> Handle(GetAnimalByIdQuery query);
    Task <IEnumerable<Animal>> Handle(GetAllAnimalsQuery query);
    Task <Animal> Handle(GetAnimalByShedIdQuery query);

 
}