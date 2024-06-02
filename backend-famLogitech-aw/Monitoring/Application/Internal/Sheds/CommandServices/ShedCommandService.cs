using backend_famLogitech_aw.Farms.Domain.Model.Aggregates;
using backend_famLogitech_aw.Farms.Domain.Model.Commands;
using backend_famLogitech_aw.Farms.Domain.Repositories;
using backend_famLogitech_aw.Farms.Domain.Services;
using backend_famLogitech_aw.Shared.Domain.Repositories;

namespace backend_famLogitech_aw.Animals.Application.Internal.Sheds.CommandServices;

public class ShedCommandService(IUnitOfWork unitOfWork,IShedRepository shedRepository):IShedCommandService
{
    public async Task<Shed> Handle(CreateShedCommand command)
    {
        var shedNew = await shedRepository.FindShedById(command.Id);
        if (shedNew != null)
            throw new Exception("Farm with ID already exists");
        shedNew = new Shed(command);
        await shedRepository.AddAsync(shedNew);
        await unitOfWork.CompleteAsync();
        return shedNew;
    }
}