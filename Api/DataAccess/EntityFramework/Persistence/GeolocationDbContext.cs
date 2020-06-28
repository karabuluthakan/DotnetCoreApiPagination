using Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.DataAccess.EntityFramework.Persistence
{
    public class GeolocationDbContext : DbContext
    {
        public GeolocationDbContext(DbContextOptions<GeolocationDbContext> options) : base(options)
        {
        }

        public GeolocationDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GeolocationDbContext).Assembly);
            /*
             * Database ilk çalıştırıldığında lokasyon ve corporate bilgilerini seed etmek için kullanıyorum.
             *  modelBuilder.GeolocationSeeding();
             */
            //    
        }

        public DbSet<Continental> Continentals { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}