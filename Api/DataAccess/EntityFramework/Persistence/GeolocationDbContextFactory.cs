using Microsoft.EntityFrameworkCore;

namespace Api.DataAccess.EntityFramework.Persistence
{
    public class GeolocationDbContextFactory : DesignTimeDbContextFactoryBase<GeolocationDbContext>
    {
        protected override GeolocationDbContext CreateNewInstance(DbContextOptions<GeolocationDbContext> options)
        {
            return new GeolocationDbContext(options);
        }
    }
}