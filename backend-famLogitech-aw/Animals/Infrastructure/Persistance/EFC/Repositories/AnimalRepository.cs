
using backend_famLogitech_aw.Animals.Domain.Model.Aggregates;
using backend_famLogitech_aw.Animals.Domain.Repositories;
using backend_famLogitech_aw.Shared.Infrastructure.Persistence.EFC.Configuration;
using backend_famLogitech_aw.Shared.Infrastructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

public class AnimalRepository : BaseRepository<Animal>, IAnimalRepository
{
    public AnimalRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Animal>> FindByAllAnimalsAsync()
    {
        return await Context.Set<Animal>().ToListAsync();
    }

    public async Task<Animal> FindByShedId(int shedId)
    {
        return await Context.Set<Animal>().FirstOrDefaultAsync(f => f.ShedId == shedId);
    }
}