using System;
using System.Net;
using System.Net.Mime;
using System.Threading.Tasks;
using Api.Business.Abstract;
using Api.Entities.Abstract;
using Api.Utilities.Extensions;
using Api.Utilities.Results;
using Api.Utilities.Results.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [
        ApiController,
        Produces(MediaTypeNames.Application.Json),
        Route("api/v1/[controller]/[action]")
    ]
    public abstract class GenericController<T, TKey, TService> : ControllerBase
        where T : class, IEntity, new() where TKey : IEquatable<TKey>
        where TService : IServiceBase<T, TKey>
    {
        private readonly TService service;

        protected GenericController(TService service)
        {
            this.service = service;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IPaginationResult<>), (int) HttpStatusCode.OK)]
        [ProducesResponseType(typeof(IResult), (int) HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(IResult), (int) HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(IResult), (int) HttpStatusCode.Forbidden)]
        [ProducesResponseType(typeof(IResult), (int) HttpStatusCode.Unauthorized)]
        public virtual async Task<IActionResult> GetAll([FromQuery] PaginationQuery paginationQuery)
        {
            var pagination = new PaginationQuery(paginationQuery.PageNumber, paginationQuery.PageSize);
            var result = await service?.GetAllAsync(null, pagination);
            return this.GetResult(result);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(IResult), (int) HttpStatusCode.OK)]
        [ProducesResponseType(typeof(IResult), (int) HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(IResult), (int) HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(IResult), (int) HttpStatusCode.Forbidden)]
        [ProducesResponseType(typeof(IResult), (int) HttpStatusCode.Unauthorized)]
        public virtual async Task<IActionResult> GetById(TKey id)
        {
            var result = await service?.GetByIdAsync(id);
            return this.GetResult(result);
        }
    }
}