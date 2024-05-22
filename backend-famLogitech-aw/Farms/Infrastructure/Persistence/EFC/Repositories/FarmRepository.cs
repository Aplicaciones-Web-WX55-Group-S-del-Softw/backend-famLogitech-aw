using backend_famLogitech_aw.Farms.Domain.Model.Aggregates;
using backend_famLogitech_aw.Farms.Domain.Repositories;
using backend_famLogitech_aw.Shared.Infrastructure.Persistence.EFC.Configuration;
using backend_famLogitech_aw.Shared.Infrastructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace backend_famLogitech_aw.Farms.Infrastructure.Persistence.EFC.Repositories;

public class FarmRepository : BaseRepository<Farm>, IFarmRepository
{
    /*min 1:36:15*/
    public FarmRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Farm>> FindByLocationAsync(string location)
    {
        return await Context.Set<Farm>().Where(f => f.Location == location).ToListAsync();
    }

    public async Task<IEnumerable<Farm>> FindByAllFarmAsync()
    {
        return await Context.Set<Farm>().ToListAsync();
    }

    public async  Task<Farm> FindByIdx(int id)
    {
        
        return await Context.Set<Farm>().FirstOrDefaultAsync(f => f.Id == id);
    }

    public async Task<Farm> UpdateFarmByIdAsync(int Id,Farm updatedFarm)
    {
        var existingFarm = await Context.Set<Farm>().FirstOrDefaultAsync(f => f.Id == updatedFarm.Id);
        if (existingFarm == null)
        {
            return null; 
        }
        updatedFarm.FarmName = updatedFarm.FarmName;
        updatedFarm.Location = updatedFarm.Location;
        updatedFarm.Type = updatedFarm.Type;
        updatedFarm.Infrastructure = updatedFarm.Infrastructure;
        updatedFarm.Certificate = updatedFarm.Certificate;
        updatedFarm.Product = updatedFarm.Product;

        await Context.SaveChangesAsync();

        return updatedFarm;
    }
}