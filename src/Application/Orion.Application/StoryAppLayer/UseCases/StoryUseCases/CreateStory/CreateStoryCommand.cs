using MediatR;
using Orion.Application.StoryAppLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Application.StoryAppLayer.UseCases.StoryUseCases.CreateStory
{
    public class CreateStoryCommand : IRequest<StoryDto>
    {
        public string Text { get; set; }
        public string[] Images { get; set; }
    }
}
