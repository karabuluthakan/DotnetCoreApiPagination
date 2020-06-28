using Api.Business.Abstract;
using Api.Entities;

namespace Api.Controllers.V1
{
    public class CountriesController : GenericController<Country, int, ICountryService>
    {
        public CountriesController(ICountryService service) : base(service)
        {
        }
    }
}