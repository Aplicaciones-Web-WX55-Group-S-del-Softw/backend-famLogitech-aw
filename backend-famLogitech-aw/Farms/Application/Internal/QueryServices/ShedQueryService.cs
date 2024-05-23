using backend_famLogitech_aw.Farms.Domain.Model.Aggregates;
using backend_famLogitech_aw.Farms.Domain.Model.Queries.Shed;
using backend_famLogitech_aw.Farms.Domain.Repositories;
using backend_famLogitech_aw.Farms.Domain.Services;

namespace backend_famLogitech_aw.Farms.Application.Internal.QueryServices;

public class ShedQueryService(IShedRepository shedRepository) :IShedQueryService
{
    public async Task<IEnumerable<Shed>> Handle(GetAllShedQuery query)
    {
        return await shedRepository.FindByAllShedAsync();
    }

    public async Task<Shed> Handle(GetShedByIdQuery query)
    {
        return await shedRepository.FindShedById(query.Id);
    }
}