using backend_famLogitech_aw.Ratings.Domain.Model.Aggregates;
using backend_famLogitech_aw.Ratings.Domain.Repositories;
using backend_famLogitech_aw.Shared.Infrastructure.Persistence.EFC.Configuration;
using backend_famLogitech_aw.Shared.Infrastructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace backend_famLogitech_aw.Ratings.Infrastructure.Persistence.EFC.Repositories;

public class RatingRepository : BaseRepository<Rating>, IRatingRepository
{
    /*minuto 1h 36min 15seg*/
    public RatingRepository(AppDbContext context) : base(context)
    {
    }
    
    public async Task<IEnumerable<Rating>> FindByAllRatingAsync()
    {
        return await Context.Set<Rating>().ToListAsync();
    }
    
    public async Task<IEnumerable<Rating>> FindByUserIdAsync(int userId)
    {
        return await Context.Set<Rating>().Where(r => r.UserId == userId).ToListAsync();
    }

    public async  Task<Rating> FindByIdx(int id)
    {
        
        return await Context.Set<Rating>().FirstOrDefaultAsync(f => f.Id == id);
    }

   
}  