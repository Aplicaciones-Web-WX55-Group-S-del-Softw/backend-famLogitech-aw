using backend_famLogitech_aw.Farms.Domain.Model.Aggregates;
using backend_famLogitech_aw.Farms.Interfaces.REST.Resources;

namespace backend_famLogitech_aw.Farms.Interfaces.Transform;

public static class FarmResourceFromEntityAssembler
{
    public static FarmResource ToResourceFromEntity(Farm entity)
    {
        return new FarmResource(entity.Id, entity.FarmName, entity.Location, entity.Type, entity.Infrastructure,
            entity.Certificate, entity.Product);
    }
}