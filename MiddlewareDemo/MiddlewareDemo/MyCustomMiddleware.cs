using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareDemo
{
    public class MyCustomMiddleware 
    {
        private readonly RequestDelegate _next;

        public MyCustomMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            await context.Response.WriteAsync("-Start of Custom Middleware-\n");
            await _next(context);
            await context.Response.WriteAsync("-End of Custom Middleware-\n");
        }
    }
}
