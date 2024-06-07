using backend_famLogitech_aw.Animals.Domain.Model.Commands;
using backend_famLogitech_aw.Animals.Interfaces.Resources;

namespace backend_famLogitech_aw.Animals.Interfaces.Transform;

public class UpdateAnimalCommandFromResourceAssembler
{
    public static UpdateAnimalCommand ToCommandFromResource(UpdateAnimalResource resource)
    {
        return new UpdateAnimalCommand(resource.Id, resource.Name, resource.Age, resource.Location,
            resource.HealthState, resource.ShedId);
    } 
}