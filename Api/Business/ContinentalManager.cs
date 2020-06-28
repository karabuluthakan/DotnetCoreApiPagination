using Api.Business.Abstract;
using Api.DataAccess.Abstract;
using Api.Entities;

namespace Api.Business
{
    public class ContinentalManager : ManagerBase<Continental, int>, IContinentalService
    {
        public ContinentalManager(IContinentalRepository repository, IPaginationUriService uriService) : base(repository, uriService)
        {
        }
    }
}