using FlowCRM.Data;
using FlowCRM.Shared.Entities;
using FlowCRM.Shared.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FlowCRM.Implementations
{
    public class ActivityRepository : IActivityRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<DealRepository> _logger;

        public ActivityRepository(ApplicationDbContext context, ILogger<DealRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IEnumerable<Activity>> GetActivitiesAsync(string? filterOn = null, string? filterQuery = null, string? sortBy = null, bool isAscending = true, int pageNumber = 1, int pageSize = 1000)
        {
            var activities = _context.Activities.AsQueryable();

            // Filter
            if (!string.IsNullOrWhiteSpace(filterOn) && !string.IsNullOrWhiteSpace(filterQuery))
            {
                if (filterOn.Equals("Deal", StringComparison.OrdinalIgnoreCase))
                {
                    activities = activities.Join(
                    _context.Deals,
                     actv => actv.FkDealId,
                     deal => deal.DealId,
                    (actv, deal) => new { actv, deal })
                        .Where(c => c.deal.DealName != null && c.deal.DealName.Contains(filterQuery))
                        .Select(c => c.actv);
                }
                else if (filterOn.Equals("Type", StringComparison.OrdinalIgnoreCase))
                {
                    activities = activities.Join(
                     _context.ActivitiesType,
                     actv => actv.FkActivityTypeId,
                     type => type.ActivityTypeId,
                    (actv, type) => new { actv, type })
                        .Where(c => c.type.TypeName != null && c.type.TypeName.Contains(filterQuery))
                        .Select(c => c.actv);
                }
            }

            // Sort
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                if (sortBy.Equals("Deal", StringComparison.OrdinalIgnoreCase))
                {
                    activities.Join(
                        _context.Deals,
                        actv => actv.FkDealId,
                        deal => deal.DealId,
                        (actv, deal) => new
                        {
                            actv,
                            deal
                        }
                        .ToString());

                    activities = isAscending ? activities.OrderBy(c => c.Deals) : activities.OrderByDescending(c => c.Deals);
                }
                else if (sortBy.Equals("Type", StringComparison.OrdinalIgnoreCase))
                {
                    activities.Join(
                        _context.ActivitiesType,
                         actv => actv.FkActivityTypeId,
                         type => type.ActivityTypeId,
                            (actv, type) => new
                            {
                                actv,
                                type
                            }
                            .ToString());

                    activities = isAscending ? activities.OrderBy(c => c.ActivitiesType) : activities.OrderByDescending(c => c.ActivitiesType);
                }
            }

            // Pagination
            var skipResults = (pageNumber - 1) * pageSize;

            return await activities.Skip(skipResults).Take(pageSize).ToListAsync();
        }

        public async Task<Activity> GetActivityAsync(Guid id)
        {
            var activity = await _context.Activities.FindAsync(id);

            if (activity == null)
            {
                throw new Exception($"No activity found with ID {id}");
            }

            return activity;
        }
        public async Task<Activity> AddActivityAsync(Activity activity)
        {
            try
            {

                if (activity == null)
                {
                    throw new Exception($"No activity found: {activity}");
                }

                activity.CreatedAt = DateTime.Now;
                await _context.Activities.AddAsync(activity);
                await _context.SaveChangesAsync();
                return activity;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error adding activity: {ex.Message}");
                throw;
                //throw new Exception($"Error adding activity: {ex.Message}");
            }
        }
        public async Task<Activity> UpdateActivityAsync(Activity activity)
        {
            var existingActivity = await _context.Activities.FindAsync(activity.ActivityId);

            if (existingActivity == null)
            {
                throw new Exception($"No activity found: {activity}");
            }

            existingActivity.FkDealId = activity.FkDealId;
            existingActivity.FkActivityTypeId = activity.FkActivityTypeId;
            existingActivity.ActivityNote = activity.ActivityNote;
            existingActivity.ActivityDate = activity.ActivityDate;
            existingActivity.UpdatedAt = DateTime.Now;
            existingActivity.UpdatedBy = activity.UpdatedBy;

            _context.Entry(existingActivity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return existingActivity;
        }

        public async Task<Activity> DeleteActivityAsync(Guid id)
        {
            var activity = await _context.Activities.FindAsync(id);

            if (activity == null)
            {
                throw new Exception($"No activity found with ID {id}");
            }

            _context.Activities.Remove(activity);
            await _context.SaveChangesAsync();
            return activity;
        }
    }
}
