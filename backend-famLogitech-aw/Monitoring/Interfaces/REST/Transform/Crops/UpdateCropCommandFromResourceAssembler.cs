using backend_famLogitech_aw.Crops.Domain.Model.Commands;
using backend_famLogitech_aw.Crops.Interfaces.Rest.Resources;
using backend_famLogitech_aw.Farms.Domain.Model.Commands;
using backend_famLogitech_aw.Farms.Interfaces.REST.Resources;

namespace backend_famLogitech_aw.Farms.Interfaces.REST.Transform.Farm;

public static class UpdateCropCommandFromResourceAssembler
{
    public static UpdateCropCommand ToCommandFromResource(UpdateCropResource resource)
    {
        return new UpdateCropCommand(resource.Id, resource.Type, resource.PlantingDate, resource.Quantity, resource.ShedId);
    }
}