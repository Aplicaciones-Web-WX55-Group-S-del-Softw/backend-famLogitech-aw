using backend_famLogitech_aw.Farms.Domain.Model.Aggregates;
using backend_famLogitech_aw.Farms.Domain.Model.Commands;

namespace backend_famLogitech_aw.Farms.Domain.Services;

public interface IFarmCommandService
{
 Task<Farm> Handle(CreateFarmCommand command);
 Task<Farm> Handle(UpdateFarmCommand command);

 
 
}