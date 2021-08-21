using MediatR;
using Orion.Application.StoryAppLayer.DTOs;
using Orion.Application.StoryAppLayer.Interfaces;
using Orion.Domain.StoryDomain.Entities;
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
        private readonly IStoryRepository _storyRepository;

        public CreateStoryCommandHandler(IStoryRepository storyRepository)
        {
            _storyRepository = storyRepository;
        }

        public async Task<StoryDto> Handle(CreateStoryCommand request, CancellationToken cancellationToken)
        {
            var story = new Story
            {
                Id = Guid.NewGuid(),
                Text = request.Text,
                Images = request.Images
            };

            var newStory = await _storyRepository.AddAsync(story);

            var storyDto = new StoryDto
            {
                Id = newStory.Id,
                Text = newStory.Text,
                Images = newStory.Images
            };

            return storyDto;
        }
    }
}
