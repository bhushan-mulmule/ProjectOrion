using MediatR;
using Orion.Application.StoryAppLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Orion.Application.StoryAppLayer.UseCases.StoryUseCases.UpdateStory
{
    public class UpdateStoryCommandHandler : IRequestHandler<UpdateStoryCommand, StoryDto>
    {
        public Task<StoryDto> Handle(UpdateStoryCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
