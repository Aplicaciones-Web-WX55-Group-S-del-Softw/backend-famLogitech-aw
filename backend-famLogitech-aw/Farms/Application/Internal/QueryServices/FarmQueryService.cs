using backend_famLogitech_aw.Farms.Domain.Model.Aggregates;
using backend_famLogitech_aw.Farms.Domain.Model.Queries;
using backend_famLogitech_aw.Farms.Domain.Repositories;
using backend_famLogitech_aw.Farms.Domain.Services;

namespace backend_famLogitech_aw.Farms.Application.Internal.QueryServices;

public class FarmQueryService(IFarmRepository farmRepository) : IFarmQueryService
{
    public async Task<Farm> Handle(GetFarmByIdQuery query)
    {
        return await farmRepository.FindByIdAsync(query.Id);
    }

    /*
    public async Task<IEnumerable<Farm>> Handle(GetFarmByLocationQuery query)
    {
        return await farmRepository.FindByLocationAsync(query.Location);
    }

    public async Task<IEnumerable<Farm>> Handle(GetAllFarmQuery query)
    {
        return await farmRepository.FindByAllFarmAsync(query.Id);
    }
    */
}