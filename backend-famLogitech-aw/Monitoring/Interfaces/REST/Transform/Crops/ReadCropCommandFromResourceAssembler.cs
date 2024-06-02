using backend_famLogitech_aw.Crops.Domain.Model.Commands;
using backend_famLogitech_aw.Crops.Interfaces.Rest.Resources;

namespace backend_famLogitech_aw.Crops.Interfaces.Rest.Transform;

public class ReadCropCommandFromResourceAssembler
{
    public static ReadCropCommand ToCommandFromResource(ReadCropResource resource)
    {
        return new ReadCropCommand(resource.Id, resource.Type, resource.PlantingDate, resource.Quantity, resource.ShedId);
    }
}