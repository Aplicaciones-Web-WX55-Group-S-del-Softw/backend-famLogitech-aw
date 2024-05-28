using backend_famLogitech_aw.Animals.Domain.Repositories;
using backend_famLogitech_aw.Crops.Domain.Model.Aggregates;
using backend_famLogitech_aw.Crops.Domain.Model.Commands;
using backend_famLogitech_aw.Crops.Domain.Repositories;
using backend_famLogitech_aw.Crops.Domain.Services;
using backend_famLogitech_aw.Farms.Domain.Model.Aggregates;
using backend_famLogitech_aw.Farms.Domain.Model.Commands;
using backend_famLogitech_aw.Shared.Domain.Repositories;

namespace backend_famLogitech_aw.Crops.Application.Internal.CommandServices;

public class CropCommandService : ICropCommandService
{
    private readonly ICropRepository _cropRepository;
    private readonly IUnitOfWork _unitOfWork;
    
    public CropCommandService(ICropRepository cropRepository)
    {
        _cropRepository = cropRepository;
    }
    
    public async Task<Crop> Handle(CreateCropCommand command)
    {
        var cropnew = await _cropRepository.FindByIdx(command.Id);
        if (cropnew != null)
            throw new Exception("Farm with ID already exists");
        cropnew = new Crop(command);
        await _cropRepository.AddAsync(cropnew);
        await _unitOfWork.CompleteAsync();
        return cropnew;
    }

    public async Task<Crop> Handle(UpdateCropCommand command)
    {
        var cropUpdate = await _cropRepository.FindByIdx(command.Id);
        if (cropUpdate == null)
            throw new Exception("Farm with ID does not exist");
        cropUpdate.Update(command);
        await _unitOfWork.CompleteAsync();
        return cropUpdate;
    }

    public Task<Crop> Handle(DeleteCropCommand command)
    {
        throw new NotImplementedException();
    }

    public Task<Crop> Handle(ReadCropCommand command)
    {
        throw new NotImplementedException();
    }
}