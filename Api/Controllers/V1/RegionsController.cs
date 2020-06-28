using Api.Business.Abstract;
using Api.Entities;

namespace Api.Controllers.V1
{
    public class RegionsController : GenericController<Region, int, IRegionService>
    {
        public RegionsController(IRegionService service) : base(service)
        {
        }
    }
}