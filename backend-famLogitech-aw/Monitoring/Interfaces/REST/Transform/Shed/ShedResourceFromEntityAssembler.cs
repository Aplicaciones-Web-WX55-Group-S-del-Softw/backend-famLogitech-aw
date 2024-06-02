using backend_famLogitech_aw.Farms.Interfaces.REST.Resources;
using backend_famLogitech_aw.Farms.Interfaces.REST.Resources.Shed;

namespace backend_famLogitech_aw.Farms.Interfaces.REST.Transform.Shed;

public static class ShedResourceFromEntityAssembler
{
    public static ShedResource ToResourceFromEntity(Domain.Model.Aggregates.Shed entity)
    {
        return new ShedResource(entity.Id, entity. FarmId,  entity. Location,  entity. Type);
    }
}