using backend_famLogitech_aw.Farms.Domain.Model.Commands;
using backend_famLogitech_aw.Farms.Interfaces.REST.Resources;

namespace backend_famLogitech_aw.Farms.Interfaces.Transform;

public static class CreateFarmCommandFromResourceAssembler
{
    public static CreateFarmCommand ToCommandFromResource(CreateFarmResource resource)
    {
        return new CreateFarmCommand(resource.Id, resource.FarmName, resource.Location, resource.Type,
            resource.Infrastructure, resource.Certificate, resource.Product);
    }
    
}