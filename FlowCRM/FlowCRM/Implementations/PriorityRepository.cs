using FlowCRM.Data;
using FlowCRM.Shared.Entities;
using FlowCRM.Shared.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FlowCRM.Implementations
{
    public class PriorityRepository : IPriorityRepository
    {
        private readonly ApplicationDbContext _context;

        public PriorityRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Priority>> GetPrioritiesAsync()
        {
            return await _context.Priorities.ToListAsync();
        }

        public async Task<Priority> GetPriorityAsync(Guid id)
        {
            var priority = await _context.Priorities.FindAsync(id);

            if (priority == null)
            {
                throw new Exception($"No priority found with ID {id}");
            }

            return priority;
        }
    }
}
