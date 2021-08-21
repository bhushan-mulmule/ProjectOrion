using MediatR;
using Orion.Application.StoryAppLayer.DTOs;
using Orion.Application.StoryAppLayer.Interfaces;
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
        private readonly IStoryRepository _storyRepository;

        public UpdateStoryCommandHandler(IStoryRepository storyRepository)
        {
            _storyRepository = storyRepository;
        }

        public async Task<StoryDto> Handle(UpdateStoryCommand request, CancellationToken cancellationToken)
        {
            var story = await _storyRepository.GetByIdAsync(request.Id);

            story.Text = request.Text;

            var updatedStory = await _storyRepository.UpdateAsync(story);

            return new StoryDto { Id = updatedStory.Id, Text = updatedStory.Text, Images = updatedStory.Images };
        }
    }
}
