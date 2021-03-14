using MediatR;
using Orion.Application.StoryAppLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Orion.Application.StoryAppLayer.UseCases.StoryUseCases.GetStories
{
    public class GetStoriesQueryHandler : IRequestHandler<GetStoriesQuery, IEnumerable<StoryDto>>
    {
        public Task<IEnumerable<StoryDto>> Handle(GetStoriesQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
