using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.StoryDomain.Entities
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class Story
    {
        public Guid Id { get; set; }   //either you can use [JsonProperty("id")] attribute just on Id property.. this will not change case of other properties.
        public string Text { get; set; }
        public string[] Images { get; set; }
    }
}
