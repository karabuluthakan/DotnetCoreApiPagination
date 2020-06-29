using System.Net;
using System.Threading.Tasks;
using Api.Business.Abstract;
using Api.Dto;
using Api.Entities;
using Api.Utilities.Results.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.V1
{
    public class CountriesController : GenericController<Country, int, ICountryService>
    {
        public CountriesController(ICountryService service) : base(service)
        {
        }

        [ProducesResponseType(typeof(IDataResult<CountryListDto>), (int) HttpStatusCode.OK)]
        public override Task<IActionResult> GetById(int id)
        {
            return base.GetById(id);
        }
    }
}