using MediatR;
using Orion.Application.StoryAppLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Application.StoryAppLayer.UseCases.StoryUseCases.DeleteStory
{
    public class DeleteStoryCommand : IRequest<StoryDto>
    {
        public Guid Id { get; set; }
    }
}
