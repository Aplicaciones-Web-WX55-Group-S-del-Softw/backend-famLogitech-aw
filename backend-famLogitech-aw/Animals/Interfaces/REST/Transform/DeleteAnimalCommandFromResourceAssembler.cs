using backend_famLogitech_aw.Animals.Domain.Model.Commands;
using backend_famLogitech_aw.Animals.Interfaces.Resources;

namespace backend_famLogitech_aw.Animals.Interfaces.Transform;

public class DeleteAnimalCommandFromResourceAssembler
{
    public static DeleteAnimalCommand ToCommandFromResource(DeleteAnimalResource resource)
    {
        return new DeleteAnimalCommand(resource.Id, resource.Name, resource.Age, resource.Location, resource.HealthState, resource.ShedId); 
    }
}