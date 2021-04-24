using Microsoft.Azure.Cosmos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.CosmosRepository.StoryRepositories
{
    public interface IStoryCosmosContext
    {
        Container StoryContainer { get; }
    }
}
