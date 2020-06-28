using Api.Business.Abstract;
using Api.DataAccess.Abstract;
using Api.Entities;

namespace Api.Business
{
    public class CountryManager : ManagerBase<Country, int>, ICountryService
    {
        public CountryManager(ICountryRepository repository, IPaginationUriService uriService) : base(repository, uriService)
        {
        }
    }
}