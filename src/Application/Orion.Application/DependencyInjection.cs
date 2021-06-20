using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Orion.Application.SeedWork.PipelineBehaviors;
using System.Reflection;

namespace Orion.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
