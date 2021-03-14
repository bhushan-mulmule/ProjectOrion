using MediatR;
using Orion.Application.StoryAppLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Orion.Application.StoryAppLayer.UseCases.StoryUseCases.CreateStory
{
    public class CreateStoryCommandHandler : IRequestHandler<CreateStoryCommand, StoryDto>
    {
        public Task<StoryDto> Handle(CreateStoryCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
