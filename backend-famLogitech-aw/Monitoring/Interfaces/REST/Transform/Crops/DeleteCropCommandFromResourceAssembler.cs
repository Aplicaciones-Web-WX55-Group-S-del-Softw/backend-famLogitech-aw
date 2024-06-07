using backend_famLogitech_aw.Crops.Domain.Model.Commands;
using backend_famLogitech_aw.Crops.Interfaces.Rest.Resources;

namespace backend_famLogitech_aw.Crops.Interfaces.Rest.Transform;

public class DeleteCropCommandFromResourceAssembler
{
    public static DeleteCropCommand ToCommandFromResource(DeleteCropResource resource)
    {
        return new DeleteCropCommand(resource.Id, resource.Type, resource.PlantingDate, resource.Quantity,
            resource.ShedId); 
    }
}