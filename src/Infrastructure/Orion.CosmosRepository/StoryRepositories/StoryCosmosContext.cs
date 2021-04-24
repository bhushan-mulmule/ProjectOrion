using Microsoft.Azure.Cosmos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.CosmosRepository.StoryRepositories
{
    public class StoryCosmosContext : IStoryCosmosContext
    {
        public StoryCosmosContext()
        {
            //For local emulator cosmosdb
            //string endpoint = "https://localhost:8081";
            //string key = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";

            //For azure protal cosmosdb (replace these values with your own)
            string endpoint = "https://aspnettutorialcosmos.documents.azure.com:443/";
            string key = "JbSGfJooxaM50b4Cxr8aQ1qqM7WYzNS3Uo1KHR1KQiEBDAmHeUChlWwXc21TKeZHobXtjhoYHbQ9RVilyXOB0Q==";

            string databaseName = "OrionDb";

            CosmosClient _client = new CosmosClient(endpoint, key);

            StoryContainer = _client.GetContainer(databaseName, "Story");
        }
        public Container StoryContainer { get; }
    }
}
