using backend_famLogitech_aw.Crops.Domain.Model.Aggregates;
using backend_famLogitech_aw.Crops.Domain.Model.Queries;
using backend_famLogitech_aw.Crops.Domain.Repositories;
using backend_famLogitech_aw.Crops.Domain.Services;

namespace backend_famLogitech_aw.Crops.Application.Internal.QueryServices;

public class CropQueryService : ICropQueryService
{
    private ICropRepository _cropRepository;
    public async Task<Crop> Handle(GetCropByIdQuery query)
    {
        return await _cropRepository.FindByIdAsync(query.Id);
    }

    public async Task<IEnumerable<Crop>> Handle(GetAllCropsQuery query)
    {
        return await _cropRepository.FindByAllCropAsync(); 
    }
}