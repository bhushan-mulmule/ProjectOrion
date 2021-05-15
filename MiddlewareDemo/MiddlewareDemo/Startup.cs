using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareDemo
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        //public void ConfigureServices(IServiceCollection services)
        //{
        //}

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseMiddleware<MyCustomMiddleware>();

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("--Start of Use Middleware--\n");  //Bad practice.. just for explanation
                await next.Invoke();
                await context.Response.WriteAsync("--End of Use Middleware--\n");    //Bad practice.. just for explanation 
            });

            app.Map("/employees", employeeDelegate);

            app.Run(async context =>
            {
                await context.Response.WriteAsync("---This is Run Middleware in Main pipeline. Deadend!!!---\n");
            });
        }

        private void employeeDelegate(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("---This is Run Middleware From Mapped pipeline. Deadend!!!---\n");
            });
        }
    }
}
