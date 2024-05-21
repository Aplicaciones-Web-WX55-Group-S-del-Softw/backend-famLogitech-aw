using backend_famLogitech_aw.Farms.Domain.Model.Aggregates;
using backend_famLogitech_aw.Shared.Infrastructure.Persistence.EFC.Configuration.Extensions;
using Microsoft.EntityFrameworkCore;

namespace backend_famLogitech_aw.Shared.Infrastructure.Persistence.EFC.Configuration;

public class AppDbContext : DbContext
{

    public AppDbContext(DbContextOptions options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Farm>().ToTable("Farms");
        builder.Entity<Farm>().HasKey(f => f.Id);
        builder.Entity<Farm>().Property(f => f.Location).ValueGeneratedNever();
        builder.Entity<Farm>().Property(f => f.Type).ValueGeneratedNever();
        builder.Entity<Farm>().Property(f => f.Infrastructure).ValueGeneratedNever();
        builder.Entity<Farm>().Property(f => f.Certificate).ValueGeneratedNever();
        builder.Entity<Farm>().Property(f => f.Product).ValueGeneratedNever();

        builder.UseSnakeCaseNamingConvention();
        
    }
}