using backend_famLogitech_aw.Ratings.Domain.Model.Aggregates;
using backend_famLogitech_aw.Ratings.Domain.Model.Commands;
using backend_famLogitech_aw.Ratings.Domain.Model.Queries;
using backend_famLogitech_aw.Ratings.Domain.Repositories;
using backend_famLogitech_aw.Ratings.Domain.Services;

namespace backend_famLogitech_aw.Ratings.Application.Internal.QueryServices;

public class RatingQueryService (IRatingRepository ratingRepository) : IRatingQueryService
{
    public async Task<Rating> Handle(GetRatingByIdQuery query)
    {
        return await ratingRepository.FindByIdAsync(query.Id);
    }
    
    public async Task<IEnumerable<Rating>> Handle(GetRatingByUserIdQuery query)
    {
        return await ratingRepository.FindByUserIdAsync(query.UserId);
    }

    public async Task<IEnumerable<Rating>> Handle(GetAllRatingQuery query)
    {
        return await ratingRepository.FindByAllRatingAsync();
    }
}