using Api.Business.Abstract;
using Api.Entities;

namespace Api.Controllers.V1
{
    public class CitiesController : GenericController<City, int, ICityService>
    {
        public CitiesController(ICityService service) : base(service)
        {
        } 
    }
}