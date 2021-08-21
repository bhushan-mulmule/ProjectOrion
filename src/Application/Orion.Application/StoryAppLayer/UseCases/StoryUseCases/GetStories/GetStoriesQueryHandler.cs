using MediatR;
using Orion.Application.StoryAppLayer.DTOs;
using Orion.Application.StoryAppLayer.Interfaces;
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
        private readonly IStoryRepository _storyRepository;

        public GetStoriesQueryHandler(IStoryRepository storyRepository)
        {
            _storyRepository = storyRepository;
        }

        public async Task<IEnumerable<StoryDto>> Handle(GetStoriesQuery request, CancellationToken cancellationToken)
        {
            var stories = await _storyRepository.GetAsync();

            var storiesDto = stories.Select(x => new StoryDto { Id = x.Id, Text = x.Text, Images = x.Images });

            return storiesDto;
        }
    }
}
