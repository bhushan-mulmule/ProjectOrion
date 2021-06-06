using Microsoft.AspNetCore.Mvc;
using Orion.API.Controllers.SeedWork;
using Orion.Application.StoryAppLayer.UseCases.StoryUseCases.CreateStory;
using Orion.Application.StoryAppLayer.UseCases.StoryUseCases.DeleteStory;
using Orion.Application.StoryAppLayer.UseCases.StoryUseCases.GetStories;
using Orion.Application.StoryAppLayer.UseCases.StoryUseCases.GetStoryById;
using Orion.Application.StoryAppLayer.UseCases.StoryUseCases.UpdateStory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orion.API.Controllers
{
    public class StoriesController : OrionBaseController
    {
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetStoriesQuery query)
        {
            var stories = await Mediator.Send(query);
            return Ok(stories);
        }

        [HttpGet("{id}")] //sotries/id
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var story = await Mediator.Send(new GetStoryByIdQuery { Id = id });
            if (story == null)
            {
                return APIErrors.RecordNotFound;
            }

            return Ok(story);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateStoryCommand command)
        {
            var story = await Mediator.Send(command);
            return CreatedAtAction("Get", new { id = story.Id }, story);
        }

        [HttpPut("{id}")]//sotries/id
        public async Task<IActionResult> Put([FromRoute] Guid id, [FromBody] UpdateStoryCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }
            var story = await Mediator.Send(command);
            return Ok(story);
        }

        [HttpDelete("{id}")]//sotries/id
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var story = await Mediator.Send(new DeleteStoryCommand { Id = id });

            if (story == null)
            {
                return APIErrors.RecordNotFound;
            }

            return Ok(story);
        }
    }
}
