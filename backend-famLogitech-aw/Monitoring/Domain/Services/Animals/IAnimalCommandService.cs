using backend_famLogitech_aw.Animals.Domain.Model.Aggregates;
using backend_famLogitech_aw.Animals.Domain.Model.Commands;

namespace backend_famLogitech_aw.Animals.Domain.Services;

public interface IAnimalCommandService
{
    Task<Animal> Handle(CreateAnimalCommand command);
    Task<Animal> Handle(UpdateAnimalCommand command);
    Task<Animal> Handle(DeleteAnimalCommand command);
    Task<Animal> Handle(ReadAnimalCommand command);
}