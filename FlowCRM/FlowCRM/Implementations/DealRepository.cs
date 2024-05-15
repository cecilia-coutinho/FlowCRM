using FlowCRM.Data;
using FlowCRM.Shared.Entities;
using FlowCRM.Shared.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FlowCRM.Implementations
{
    public class DealRepository : IDealRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<DealRepository> _logger;

        public DealRepository(ApplicationDbContext context, ILogger<DealRepository> logger)
        {
            _context = context;
            _logger = logger;
        }
        public async Task<IEnumerable<Deal>> GetDealsAsync(string? filterOn = null, string? filterQuery = null, string? sortBy = null, bool isAscending = true, int pageNumber = 1, int pageSize = 1000)
        {

            var deals = _context.Deals.AsQueryable();

            // Filter
            if (!string.IsNullOrWhiteSpace(filterOn) && !string.IsNullOrWhiteSpace(filterQuery))
            {
                if (filterOn.Equals("DealName", StringComparison.OrdinalIgnoreCase))
                {
                    deals = deals.Where(c => c.DealName != null && c.DealName.Contains(filterQuery));
                }
                else if (filterOn.Equals("DealAmount", StringComparison.OrdinalIgnoreCase))
                {
                    if (filterQuery.StartsWith('-'))
                    {
                        throw new ArgumentException($"Invalid filter query for DealAmount: '{filterQuery}'. It can not be < 0", "filterQuery");
                    }
                    else if (filterQuery.Contains('-'))
                    {
                        var bounds = filterQuery.Split('-');
                        if (bounds.Length == 2
                            && decimal.TryParse(bounds[0], out decimal min)
                            && decimal.TryParse(bounds[1], out decimal max))
                        {
                            deals = deals.Where(c => c.DealAmount >= min && c.DealAmount <= max);
                        }
                    }
                    else if (decimal.TryParse(filterQuery, out decimal amount))
                    {
                        deals = deals.Where(c => c.DealAmount == amount);
                    }
                    else
                    {
                        throw new ArgumentException($"Invalid filter query for DealAmount: '{filterQuery}'", "filterQuery");
                    }

                }
                else if (filterOn.Equals("CustomerName", StringComparison.OrdinalIgnoreCase))
                {
                    deals = deals.Join(
                        _context.Customers,
                        contact => contact.FkCustomerId,
                        customer => customer.CustomerId,
                        (contact, customer) => new { contact, customer }
                        )
                        .Where(c => c.customer.FirstName != null && c.customer.FirstName.Contains(filterQuery) && c.customer.LastName != null || c.customer.LastName != null && c.customer.LastName.Contains(filterQuery))
                        .Select(c => c.contact);
                }
                else if (filterOn.Equals("Priority", StringComparison.OrdinalIgnoreCase))
                {
                    deals = deals.Join(
                    _context.Priorities,
                     deal => deal.FkPriorityId,
                     priority => priority.PriorityId,
                    (deal, priority) => new { deal, priority })
                        .Where(c => c.priority.PriorityName != null && c.priority.PriorityName.Contains(filterQuery))
                        .Select(c => c.deal);
                }
                else if (filterOn.Equals("DealStatus", StringComparison.OrdinalIgnoreCase))
                {
                    deals = deals.Join(
                     _context.DealsStatus,
                     deal => deal.FkDealStatusId,
                     dealStatus => dealStatus.DealStatusId,
                    (deal, dealStatus) => new { deal, dealStatus })
                        .Where(c => c.dealStatus.StatusName != null && c.dealStatus.StatusName.Contains(filterQuery))
                        .Select(c => c.deal);
                }
            }

            // Sort
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                if (sortBy.Equals("DealName", StringComparison.OrdinalIgnoreCase))
                {
                    deals = isAscending ? deals.OrderBy(c => c.DealName) : deals.OrderByDescending(c => c.DealName);
                }
                else if (sortBy.Equals("DealAmount", StringComparison.OrdinalIgnoreCase))
                {
                    deals = isAscending ? deals.OrderBy(c => c.DealAmount) : deals.OrderByDescending(c => c.DealAmount);
                }
                else if (sortBy.Equals("Priority", StringComparison.OrdinalIgnoreCase))
                {
                    deals.Join(
                        _context.Priorities,
                        deal => deal.FkPriorityId,
                        priority => priority.PriorityId,
                        (deal, priority) => new
                        {
                            deal,
                            priority
                        }
                        .ToString());

                    deals = isAscending ? deals.OrderBy(c => c.Priorities) : deals.OrderByDescending(c => c.Priorities);
                }
                else if (sortBy.Equals("DealStatus", StringComparison.OrdinalIgnoreCase))
                {
                    deals.Join(
                        _context.DealsStatus,
                         deal => deal.FkDealStatusId,
                         dealStatus => dealStatus.DealStatusId,
                            (deal, dealStatus) => new
                            {
                                deal,
                                dealStatus
                            }
                            .ToString());

                    deals = isAscending ? deals.OrderBy(c => c.DealsStatus) : deals.OrderByDescending(c => c.DealsStatus);
                }
            }

            // Pagination
            var skipResults = (pageNumber - 1) * pageSize;

            return await deals.Skip(skipResults).Take(pageSize).ToListAsync();

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
            try
            {
                if (deal == null)
                {
                    throw new Exception($"Deal can not be null: {deal}");
                }

                deal.CreatedAt = DateTime.Now;
                await _context.Deals.AddAsync(deal);
                await _context.SaveChangesAsync();
                return deal;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding deal");
                throw;
            }
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
