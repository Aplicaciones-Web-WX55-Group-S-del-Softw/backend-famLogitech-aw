using backend_famLogitech_aw.Farms.Domain.Model.Aggregates;
using backend_famLogitech_aw.Farms.Domain.Model.Queries;

namespace backend_famLogitech_aw.Farms.Domain.Services;

public interface IFarmQueryService
{
    Task<Farm> Handle(GetFarmByIdQuery query);
    /*
    Task<IEnumerable<Farm>> Handle(GetFarmByLocationQuery query);
    Task<IEnumerable<Farm>> Handle(GetAllFarmQuery query);
    
    */

    
}