using backend_famLogitech_aw.Ratings.Domain.Model.Aggregates;
using backend_famLogitech_aw.Shared.Domain.Repositories;

namespace backend_famLogitech_aw.Ratings.Domain.Repositories;

public interface IRatingRepository: IBaseRepository<Rating>
{
    Task<IEnumerable<Rating>> FindByUserIdAsync(int userId);
 
    Task<IEnumerable<Rating>> FindByAllRatingAsync();
   
    
    Task<Rating> FindByIdx(int id);
}