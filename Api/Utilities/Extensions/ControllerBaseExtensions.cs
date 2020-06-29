using System;
using System.Net;
using Api.Utilities.Results.Abstract;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Api.Utilities.Extensions
{
    public static class ControllerBaseExtensions
    {
        public static IActionResult GetResult(this ControllerBase controllerBase, IResult result)
        {
            switch (result.StatusCode)
            {
                case (int) HttpStatusCode.Created:
                {
                    var uri = (controllerBase?.HttpContext?.Request).GetDisplayUrl();
                    if (string.IsNullOrEmpty(result.Message))
                    {
                        result.Message = "Created";
                    }
                    return new CreatedResult(uri, result); 
                }
                case (int) HttpStatusCode.NotFound:
                {
                    if (string.IsNullOrEmpty(result.Message))
                    {
                        result.Message = "NotFound";
                    }
                    return new NotFoundObjectResult(result);
                }
                case (int) HttpStatusCode.NoContent:
                {
                    return new NoContentResult();
                }
                case (int) HttpStatusCode.Forbidden:
                {
                    if (string.IsNullOrEmpty(result.Message))
                    {
                        result.Message = "Forbidden";
                    }
                    return new ForbidResult();
                }
                case (int) HttpStatusCode.Unauthorized:
                {
                    return new UnauthorizedResult();
                }
                case (int) HttpStatusCode.OK:
                {
                    if (string.IsNullOrEmpty(result.Message))
                    {
                        result.Message = "OK";
                    }
                    return new OkObjectResult(result);
                }
                default:
                {
                    if (string.IsNullOrEmpty(result.Message))
                    {
                        result.Message = "Something went wrong";
                    }
                    return new BadRequestObjectResult(result);
                }
            }
        } 
    }
}