using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Application.StoryAppLayer.DTOs
{
    public class StoryDto
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public string[] Images { get; set; }
    }
}
