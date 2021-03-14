using Orion.Application.StoryAppLayer.Gateway;
using Orion.Domain.StoryDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Repository.StoryRepositories
{
    public class StoryRepository : IStoryRepository
    {
        public Task<Story> AddAsync(Story story)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Story>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Story> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Story> RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Story> UpdateAsync(Story story)
        {
            throw new NotImplementedException();
        }
    }
}
