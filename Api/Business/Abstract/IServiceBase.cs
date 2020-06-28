using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Api.Entities.Abstract;
using Api.Utilities.Results;
using Api.Utilities.Results.Abstract;

namespace Api.Business.Abstract
{
    public interface IServiceBase<T, in TKey>
        where T : class, IEntity, new() where TKey : IEquatable<TKey>
    {
        Task<IResult> GetAllAsync(Expression<Func<T, bool>> predicate = null, PaginationQuery paginationQuery = null);
        Task<IResult> GetByIdAsync(TKey id);
    }
}