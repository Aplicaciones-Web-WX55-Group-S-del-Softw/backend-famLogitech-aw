using backend_famLogitech_aw.Animals.Domain.Model.Commands;
using backend_famLogitech_aw.Animals.Interfaces.Resources;

namespace backend_famLogitech_aw.Animals.Interfaces.Transform;


public class ReadAnimalCommandFromResourceAssembler
{
    public static ReadAnimalCommand ToCommandFromResource(ReadAnimalResource resource)
    {
        return new ReadAnimalCommand(resource.Id, resource.Name, resource.Age, resource.Location,
            resource.HealthState, resource.ShedId); 
    }
}