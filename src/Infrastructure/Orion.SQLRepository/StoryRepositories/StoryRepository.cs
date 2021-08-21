using Microsoft.EntityFrameworkCore;
using Orion.Application.StoryAppLayer.Interfaces;
using Orion.Domain.StoryDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.SQLRepository.StoryRepositories
{
    public class StoryRepository : IStoryRepository
    {
        private readonly StoryDbContext _storyDbContext;

        public StoryRepository(StoryDbContext storyDbContext)
        {
            _storyDbContext = storyDbContext;
        }

        public async Task<IEnumerable<Story>> GetAsync()
        {
            return await _storyDbContext.Story.ToListAsync();
        }

        public async Task<Story> GetByIdAsync(Guid id)
        {
            return await _storyDbContext.Story.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Story> AddAsync(Story story)
        {
            await _storyDbContext.AddAsync(story);
            await _storyDbContext.SaveChangesAsync();
            return story;
        }

        public async Task<Story> UpdateAsync(Story story)
        {
            _storyDbContext.Update(story);
            await _storyDbContext.SaveChangesAsync();
            return story;
        }

        public async Task<Story> RemoveAsync(Guid id)
        {
            var storyToRemove = await GetByIdAsync(id);
            _storyDbContext.Story.Remove(storyToRemove);
            await _storyDbContext.SaveChangesAsync();
            return storyToRemove;
        }
    }
}
