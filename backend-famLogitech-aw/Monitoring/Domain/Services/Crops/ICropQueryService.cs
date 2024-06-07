using backend_famLogitech_aw.Crops.Domain.Model.Aggregates;
using backend_famLogitech_aw.Crops.Domain.Model.Queries;

namespace backend_famLogitech_aw.Crops.Domain.Services;

public interface ICropQueryService
{
    Task<Crop> Handle(GetCropByIdQuery query);
    Task<IEnumerable<Crop>> Handle(GetAllCropsQuery query);
}