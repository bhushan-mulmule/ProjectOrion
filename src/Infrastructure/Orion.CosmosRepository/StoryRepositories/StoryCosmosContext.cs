using Microsoft.Azure.Cosmos;
using Orion.CosmosRepository.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.CosmosRepository.StoryRepositories
{
    public class StoryCosmosContext : IStoryCosmosContext
    {
        public StoryCosmosContext(CosmosSettings cosmosSettings)
        {
            CosmosClient _client = new CosmosClient(cosmosSettings.Endpoint, cosmosSettings.Key);

            StoryContainer = _client.GetContainer(cosmosSettings.DatabaseName, cosmosSettings.StoryContainer);
        }
        public Container StoryContainer { get; }
    }
}
