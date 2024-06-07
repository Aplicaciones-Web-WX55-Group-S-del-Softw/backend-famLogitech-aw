using backend_famLogitech_aw.Crops.Domain.Model.Aggregates;
using backend_famLogitech_aw.Crops.Domain.Model.Commands;

namespace backend_famLogitech_aw.Crops.Domain.Services;

public interface ICropCommandService
{
    Task<Crop> Handle(CreateCropCommand command); 
    Task<Crop> Handle(UpdateCropCommand command);
    Task<Crop> Handle(DeleteCropCommand command);
    Task<Crop> Handle(ReadCropCommand command);

}