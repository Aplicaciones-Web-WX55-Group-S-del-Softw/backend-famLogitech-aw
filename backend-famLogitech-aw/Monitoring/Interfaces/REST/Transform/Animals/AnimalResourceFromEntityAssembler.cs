using backend_famLogitech_aw.Animals.Domain.Model.Aggregates;
using backend_famLogitech_aw.Animals.Interfaces.Resources;

namespace backend_famLogitech_aw.Animals.Interfaces.Transform;

public class AnimalResourceFromEntityAssembler
{
    public static AnimalResource ToResourceFromEntity(Animal entity)
    {
        return new AnimalResource(entity.Id, entity.Age, entity.Location, entity.ShedId, entity.Name, entity.HealthState);
    }
}