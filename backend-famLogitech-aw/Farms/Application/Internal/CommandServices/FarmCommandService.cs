using backend_famLogitech_aw.Farms.Domain.Model.Aggregates;
using backend_famLogitech_aw.Farms.Domain.Model.Commands;
using backend_famLogitech_aw.Farms.Domain.Repositories;
using backend_famLogitech_aw.Farms.Domain.Services;
using backend_famLogitech_aw.Shared.Infrastructure;

namespace backend_famLogitech_aw.Farms.Application.Internal.CommandServices;

public class FarmCommandService : IFarmCommandService : IFarmCommandService
{
    private readonly IFarmRepository _farmRepository;
    private readonly IUnitOfWork _unitOfWork;

   


public FarmCommandService(IFarmRepository farmRepository, IUnitOfWork unitOfWork)
    {
        _farmRepository = farmRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Farm> Handle(CreateFarmCommand command)
    {
        var farm = await _farmRepository.FindByLocationAsync(command.Location);
        if (farm != null)
        
            throw new Exception("Farm already exists in this location");
        farm= new Farm(command);
        await _farmRepository.AddAsync(farm);
        await _unitOfWork.CompleteAsync();
        return farm;

    }
}