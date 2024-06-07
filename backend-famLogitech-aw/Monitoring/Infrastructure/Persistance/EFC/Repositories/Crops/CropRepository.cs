using backend_famLogitech_aw.Crops.Domain.Model.Aggregates;
using backend_famLogitech_aw.Crops.Domain.Repositories;
using backend_famLogitech_aw.Shared.Domain.Repositories;
using backend_famLogitech_aw.Shared.Infrastructure.Persistence.EFC.Configuration;
using backend_famLogitech_aw.Shared.Infrastructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace backend_famLogitech_aw.Crops.Infrastructure.Persistence.EFC.Repositories;

public class CropRepository : BaseRepository<Crop>, ICropRepository
{
    public CropRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Crop>> FindByAllCropAsync()
    {
        return await Context.Set<Crop>().ToListAsync();
    }

    public async Task<Crop> FindByIdx(int id)
    {
        return await Context.Set<Crop>().FirstOrDefaultAsync(f => f.Id == id);
    }

    public async Task DeleteAsync(Crop crop)
    {
        Context.Set<Crop>().Remove(crop);
        await Context.SaveChangesAsync();
    }
}