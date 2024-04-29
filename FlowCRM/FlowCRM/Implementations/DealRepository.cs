using FlowCRM.Data;
using FlowCRM.Shared.Entities;
using FlowCRM.Shared.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FlowCRM.Implementations
{
	public class DealRepository : IDealRepository
	{
		private readonly ApplicationDbContext _context;

		public DealRepository(ApplicationDbContext context)
		{
			_context = context;
		}
		public async Task<IEnumerable<Deal>> GetDealsAsync()
		{
			return await _context.Deals.ToListAsync();
		}

		public async Task<Deal> GetDealAsync(Guid id)
		{
			var deal = await _context.Deals.FindAsync(id);

			if (deal == null)
			{
				throw new Exception($"No deal found with ID {id}");
			}

			return deal;
		}

		public async Task<Deal> AddDealAsync(Deal deal)
		{
			if (deal == null)
			{
				throw new Exception($"No deal found: {deal}");
			}

			deal.CreatedAt = DateTime.Now;
			_context.Deals.Add(deal);
			await _context.SaveChangesAsync();
			return deal;
		}
		public async Task<Deal> UpdateDealAsync(Deal deal)
		{
			var existingDeal = await _context.Deals.FindAsync(deal.DealId);

			if (existingDeal == null)
			{
				throw new Exception($"No deal found: {deal}");
			}

			existingDeal = deal;
			existingDeal.UpdatedAt = DateTime.Now;
			_context.Entry(existingDeal).State = EntityState.Modified;
			await _context.SaveChangesAsync();
			return existingDeal;
		}

		public async Task<Deal> DeleteDealAsync(Guid id)
		{
			var deal = await _context.Deals.FindAsync(id);

			if (deal == null)
			{
				throw new Exception($"No deal found with ID {id}");
			}

			_context.Deals.Remove(deal);
			await _context.SaveChangesAsync();
			return deal;
		}
	}
}
