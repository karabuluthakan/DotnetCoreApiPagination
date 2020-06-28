using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Api.Entities.Abstract;
using Api.Utilities.Results;

namespace Api.DataAccess.Abstract
{
    public interface IRepository<T, in TKey> where T : class, IEntity, new() where TKey : IEquatable<TKey>
    {
        IQueryable<T> Get(Expression<Func<T, bool>> predicate = null, PaginationQuery paginationQuery = null);
        Task<T> GetByIdAsync(TKey id);

        Task<int> CountAsync();
    }
}