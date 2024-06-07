using backend_famLogitech_aw.Ratings.Domain.Model.Aggregates;
using backend_famLogitech_aw.Ratings.Domain.Model.Commands;
using backend_famLogitech_aw.Ratings.Domain.Model.Queries;

namespace backend_famLogitech_aw.Ratings.Domain.Services; 

public interface IRatingQueryService
{
    Task<Rating> Handle(GetRatingByIdQuery query);
    
    Task<IEnumerable<Rating>> Handle(GetRatingByUserIdQuery query);
    
    Task<IEnumerable<Rating>> Handle(GetAllRatingQuery query);
}