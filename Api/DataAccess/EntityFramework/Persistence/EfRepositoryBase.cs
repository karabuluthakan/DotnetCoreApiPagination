﻿using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Api.DataAccess.Abstract;
using Api.Entities.Abstract;
using Api.Utilities.Results;
using Microsoft.EntityFrameworkCore;

namespace Api.DataAccess.EntityFramework.Persistence
{
    public abstract class EfRepositoryBase<T, TKey> : IRepository<T, TKey>
        where T : class, IEntity<TKey>, new() where TKey : IEquatable<TKey>
    {
        protected GeolocationDbContext Context { get; }
        protected readonly DbSet<T> dbSet;

        protected EfRepositoryBase(GeolocationDbContext dbContext)
        {
            this.Context = dbContext;
            dbSet = dbContext.Set<T>();
        }

        public virtual IQueryable<T> Get(Expression<Func<T, bool>> predicate = null, PaginationQuery paginationQuery = null)
        {
            var query = dbSet.AsQueryable();

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            if (paginationQuery != null)
            {
                var skip = (paginationQuery.PageNumber - 1) * paginationQuery.PageSize;
                query = query.Skip(skip).Take(paginationQuery.PageSize);
            }

            return query.AsNoTracking();
        }

        public virtual Task<T> GetByIdAsync(TKey id)
        {
            return dbSet.FirstOrDefaultAsync(x => x.Id.Equals(id));
        }

        public Task<int> CountAsync()
        {
            return dbSet.CountAsync();
        }
    }
}