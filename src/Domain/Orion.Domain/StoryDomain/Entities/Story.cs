using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.StoryDomain.Entities
{
    public class Story
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
    }
}
