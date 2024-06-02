using backend_famLogitech_aw.Farms.Domain.Model.Aggregates;
using backend_famLogitech_aw.Farms.Domain.Model.Commands;

namespace backend_famLogitech_aw.Farms.Domain.Services;

public interface IShedCommandService
{
    Task<Shed> Handle(CreateShedCommand command);

}