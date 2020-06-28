using Api.Business.Abstract;
using Api.DataAccess.Abstract;
using Api.Entities;

namespace Api.Business
{
    public class RegionManager : ManagerBase<Region, int>, IRegionService
    {
        public RegionManager(IRegionRepository repository, IPaginationUriService uriService) : base(repository, uriService)
        {
        }
    }
}