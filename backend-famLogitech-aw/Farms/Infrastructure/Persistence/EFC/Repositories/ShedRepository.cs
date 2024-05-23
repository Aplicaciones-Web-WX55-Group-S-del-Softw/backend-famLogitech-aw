using backend_famLogitech_aw.Farms.Domain.Model.Aggregates;
using backend_famLogitech_aw.Farms.Domain.Repositories;
using backend_famLogitech_aw.Shared.Infrastructure.Persistence.EFC.Configuration;
using backend_famLogitech_aw.Shared.Infrastructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace backend_famLogitech_aw.Farms.Infrastructure.Persistence.EFC.Repositories;

public class  ShedRepository : BaseRepository<Shed>, IShedRepository
{
    public ShedRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Shed>> FindByAllShedAsync()
    {
        return await Context.Set<Shed>().ToListAsync();
    }

    public async Task<Shed> FindShedById(int id)
    {
        return await Context.Set<Shed>().FirstOrDefaultAsync(f => f.Id == id);
    }
}