using backend_famLogitech_aw.Animals.Domain.Model.Aggregates;
using backend_famLogitech_aw.Crops.Domain.Model.Aggregates;
using backend_famLogitech_aw.Farms.Domain.Model.Aggregates;
using backend_famLogitech_aw.Shared.Infrastructure.Persistence.EFC.Configuration.Extensions;
using EntityFrameworkCore.CreatedUpdatedDate.Extensions;
using Microsoft.EntityFrameworkCore;

namespace backend_famLogitech_aw.Shared.Infrastructure.Persistence.EFC.Configuration
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.AddCreatedUpdatedInterceptor();
            base.OnConfiguring(builder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

                //BORRAR TODAS LAS TABLAS ANTES DE CREAR NUEVAS, PARA QUE SE ACTUALICE
            // Configuración de la entidad Farm
            builder.Entity<Farm>().ToTable("Farms");
            builder.Entity<Farm>().HasKey(f => f.Id);
            builder.Entity<Farm>().Property(f => f.Location);
            builder.Entity<Farm>().Property(f => f.Type);
            builder.Entity<Farm>().Property(f => f.Infrastructure);
            builder.Entity<Farm>().Property(f => f.Certificate);
            builder.Entity<Farm>().Property(f => f.Product);
            builder.UseSnakeCaseNamingConvention();

            // Configuración de la entidad Shed
            builder.Entity<Shed>().ToTable("Sheds");
            builder.Entity<Shed>().HasKey(f => f.Id);
            builder.Entity<Shed>().Property(f => f.FarmId);
            builder.Entity<Shed>().Property(f => f.Location);
            builder.Entity<Shed>().Property(f => f.Type);
            
            builder.UseSnakeCaseNamingConvention();
            
            //Configuracion de la entidad Animal
            builder.Entity<Animal>().ToTable("Animals");
            builder.Entity<Animal>().HasKey(f => f.Id);
            builder.Entity<Animal>().Property(f => f.Age);
            builder.Entity<Animal>().Property(f => f.Location);
            builder.Entity<Animal>().Property(f => f.HealthState);
            builder.Entity<Animal>().Property(f => f.ShedId);
            builder.UseSnakeCaseNamingConvention();
            
            //Configuracion de la entidad Crop
            builder.Entity<Crop>().ToTable("Crops");
            builder.Entity<Crop>().HasKey(f => f.Id);
            builder.Entity<Crop>().Property(f => f.Type);
            builder.Entity<Crop>().Property(f => f.PlantingDate);
            builder.Entity<Crop>().Property(f => f.Quantity);
            builder.Entity<Crop>().Property(f => f.ShedId);
            builder.UseSnakeCaseNamingConvention();
            
        }
    }
}