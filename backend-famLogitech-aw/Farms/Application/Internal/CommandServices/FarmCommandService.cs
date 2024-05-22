using backend_famLogitech_aw.Farms.Domain.Model.Aggregates;
using backend_famLogitech_aw.Farms.Domain.Model.Commands;
using backend_famLogitech_aw.Farms.Domain.Repositories;
using backend_famLogitech_aw.Farms.Domain.Services;
using backend_famLogitech_aw.Shared.Domain.Repositories;

namespace backend_famLogitech_aw.Farms.Application.Internal.CommandServices;

public class FarmCommandService(IUnitOfWork unitOfWork, IFarmRepository farmRepository) : IFarmCommandService
{
    public async Task<Farm> Handle(CreateFarmCommand command)
    {
        var farmNew = await farmRepository.FindByIdx(command.Id);
        if (farmNew != null)
            throw new Exception("Farm with ID already exists");
        farmNew = new Farm(command);
        await farmRepository.AddAsync(farmNew);
        await unitOfWork.CompleteAsync();
        return farmNew;
    }
    
}