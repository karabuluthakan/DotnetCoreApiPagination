using Api.Business.Abstract;
using Api.DataAccess.Abstract;
using Api.Entities;

namespace Api.Business
{
    public class CityManager : ManagerBase<City, int>, ICityService
    {
        public CityManager(ICityRepository repository, IPaginationUriService uriService) : base(repository, uriService)
        {
        }
    }
}