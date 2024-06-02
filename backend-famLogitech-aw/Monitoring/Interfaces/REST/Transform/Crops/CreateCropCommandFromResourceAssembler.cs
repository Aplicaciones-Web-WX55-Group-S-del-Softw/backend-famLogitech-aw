using backend_famLogitech_aw.Crops.Domain.Model.Commands;
using backend_famLogitech_aw.Crops.Interfaces.Rest.Resources;

namespace backend_famLogitech_aw.Crops.Interfaces.Rest.Transform;

public static class CreateCropCommandFromResourceAssembler
{
    public static CreateCropCommand ToCommandFromResource( CreateCropResource resource)
    {
        return new CreateCropCommand(resource.Id, resource.Type, resource.PlantingDate, resource.Quantity, resource.ShedId);
    }
}