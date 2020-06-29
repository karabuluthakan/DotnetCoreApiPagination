using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Threading.Tasks;
using Api.DataAccess.Abstract;
using Api.Entities.Abstract;
using Api.Utilities.Extensions;
using Api.Utilities.Results;
using Api.Utilities.Results.Abstract;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Api.Business.Abstract
{
    public abstract class ManagerBase<T, TKey> : IServiceBase<T, TKey>
        where T : class, IEntity, new() where TKey : IEquatable<TKey>
    {
        protected readonly IPaginationUriService uriService;
        protected readonly IRepository<T, TKey> repository;

        protected ManagerBase(IRepository<T, TKey> repository, IPaginationUriService uriService)
        {
            this.uriService = uriService;
            this.repository = repository;
        }


        public virtual async Task<IResult> GetAllAsync(Expression<Func<T, bool>> predicate = null, PaginationQuery paginationQuery = null)
        {
            var data = repository.Get(predicate, paginationQuery);
            if (data == null)
            {
                return new Result(HttpStatusCode.NotFound, "NotFound");
            }

            var list = await data.ToListAsync();
            var count = await repository.CountAsync();
            return PaginationExtensions.CreatePaginationResult(list, HttpStatusCode.OK, paginationQuery, count, uriService);
        }

        public virtual async Task<IResult> GetByIdAsync(TKey id)
        {
            var data = await repository.GetByIdAsync(id);
            return data == null ? new Result(HttpStatusCode.NotFound, "NotFound") : new DataResult<T>(data, HttpStatusCode.OK, 1);
        }
    }
}