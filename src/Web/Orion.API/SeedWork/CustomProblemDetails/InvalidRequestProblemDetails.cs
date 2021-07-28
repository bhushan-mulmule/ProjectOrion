using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Orion.Application.SeedWork.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orion.API.SeedWork.CustomProblemDetails
{
    public class InvalidRequestProblemDetails : ProblemDetails
    {
        public List<string> Errors { get; }

        public InvalidRequestProblemDetails(InvalidRequestException exception, string traceId)
        {
            Title = "Request validation error";
            Status = StatusCodes.Status400BadRequest;
            Type = "https://httpstatuses.com/400";
            Errors = exception.Errors;
            Instance = traceId;
        }
    }
}
