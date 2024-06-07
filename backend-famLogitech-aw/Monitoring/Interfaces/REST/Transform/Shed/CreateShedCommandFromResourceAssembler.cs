using backend_famLogitech_aw.Farms.Domain.Model.Commands;
using backend_famLogitech_aw.Farms.Interfaces.REST.Resources.Shed;

namespace backend_famLogitech_aw.Farms.Interfaces.REST.Transform.Shed;

public static class CreateShedCommandFromResourceAssembler
{
    public static CreateShedCommand ToCommandFromResource(CreateShedResource resource)
    {
        return new CreateShedCommand(resource.Id, resource. FarmId,  resource. Location,  resource. Type);;
    }
}