using FlowCRM.Data;
using FlowCRM.Shared.Entities;
using FlowCRM.Shared.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FlowCRM.Implementations
{
    public class DealStatusRepository : IDealStatusRepository
    {
        private readonly ApplicationDbContext _context;

        public DealStatusRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<DealStatus>> GetDealStatusesAsync()
        {
            return await _context.DealsStatus.ToListAsync();
        }

        public async Task<DealStatus> GetDealStatusAsync(Guid id)
        {
            var dealStatus = await _context.DealsStatus.FindAsync(id);

            if (dealStatus == null)
            {
                throw new Exception($"No deal status found with ID {id}");
            }

            return dealStatus;
        }

    }
}
