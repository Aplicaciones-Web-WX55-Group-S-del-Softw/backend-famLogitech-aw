using backend_famLogitech_aw.Farms.Domain.Model.Commands;
using backend_famLogitech_aw.Farms.Interfaces.REST.Resources;

namespace backend_famLogitech_aw.Farms.Interfaces.REST.Transform.Farm;

public static class UpdateFarmCommandFromResourceAssembler
{
    public static UpdateFarmCommand ToCommandFromResource(UpdateFarmResource resource)
    {
        return new UpdateFarmCommand(resource.Id, resource.FarmName, resource.Location, resource.Type,
            resource.Infrastructure, resource.Certificate, resource.Product);
    }
}