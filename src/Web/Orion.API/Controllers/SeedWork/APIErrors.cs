using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Orion.API.Controllers.SeedWork
{
    public static class APIErrors
    {
        public static NotFoundObjectResult RecordNotFound
        {
            get
            {
                var problemDetails = new ProblemDetails
                {
                    Status = (int)HttpStatusCode.NotFound,
                    Type = "https://httpstatuses.com/404",
                    Title = "Record not found",
                    Detail = "No record exist in database with specified Id. Please try again using valid Id",
                };

                return new NotFoundObjectResult(problemDetails);
            }
        }
    }
}
