using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Orion.Application.StoryAppLayer.Interfaces;
using Orion.CosmosRepository.Settings;
using Orion.CosmosRepository.StoryRepositories;

namespace Orion.CosmosRepository
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCosmosRepository(this IServiceCollection services, IConfiguration configuration)
        {
            var cosmosSettings = new CosmosSettings();
            configuration.GetSection(CosmosSettings.SettingName).Bind(cosmosSettings);
            services.AddSingleton(cosmosSettings);

            services.AddSingleton<IStoryCosmosContext, StoryCosmosContext>();

            services.AddScoped<IStoryRepository, StoryRepository>();

            return services;
        }
    }
}
