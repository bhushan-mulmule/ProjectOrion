using Microsoft.Extensions.DependencyInjection;
using Orion.Application.StoryAppLayer.Gateway;
using Orion.SQLRepository.StoryRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.SQLRepository
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddScoped<StoryDbContext>();
            services.AddScoped<IStoryRepository, StoryRepository>();
            return services;
        }
    }
}
