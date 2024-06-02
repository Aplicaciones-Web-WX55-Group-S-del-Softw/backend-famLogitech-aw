using backend_famLogitech_aw.Farms.Domain.Model.Aggregates;
using backend_famLogitech_aw.Farms.Domain.Model.Queries.Shed;

namespace backend_famLogitech_aw.Farms.Domain.Services;

public interface IShedQueryService
{
    Task<IEnumerable<Shed>> Handle(GetAllShedQuery query);
    Task<Shed> Handle(GetShedByIdQuery query);

}