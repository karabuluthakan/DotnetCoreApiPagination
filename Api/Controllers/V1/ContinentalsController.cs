using Api.Business.Abstract;
using Api.Entities;

namespace Api.Controllers.V1
{
    public class ContinentalsController : GenericController<Continental, int, IContinentalService>
    {
        public ContinentalsController(IContinentalService service) : base(service)
        {
        }
    }
}