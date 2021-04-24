using Microsoft.Extensions.DependencyInjection;
using Orion.Application.StoryAppLayer.Gateway;
using Orion.CosmosRepository.StoryRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.CosmosRepository
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCosmosRepository(this IServiceCollection services)
        {
            services.AddSingleton<IStoryCosmosContext, StoryCosmosContext>();

            services.AddScoped<IStoryRepository, StoryRepository>();

            return services;
        }
    }
}
