using backend_famLogitech_aw.Crops.Domain.Model.Aggregates;
using backend_famLogitech_aw.Crops.Interfaces.Rest.Resources;

namespace backend_famLogitech_aw.Crops.Interfaces.Rest.Transform;

public static class CropResourceFromEntityAssembler
{
    public static CropResource ToResourceFromEntity(Crop entity)
    {
        return new CropResource(entity.Id, entity.Type, entity.PlantingDate, entity.Quantity, entity.ShedId);
    }
}