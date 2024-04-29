using FlowCRM.Data;
using FlowCRM.Shared.Entities;
using FlowCRM.Shared.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FlowCRM.Implementations
{
	public class ActivityRepository : IActivityRepository
	{
		private readonly ApplicationDbContext _context;

		public ActivityRepository(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<Activity>> GetActivitiesAsync()
		{
			return await _context.Activities.ToListAsync();
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
			if (activity == null)
			{
				throw new Exception($"No activity found: {activity}");
			}

			activity.CreatedAt = DateTime.Now;
			_context.Activities.Add(activity);
			await _context.SaveChangesAsync();
			return activity;
		}
		public async Task<Activity> UpdateActivityAsync(Activity activity)
		{
			var existingActivity = await _context.Activities.FindAsync(activity.ActivityId);

			if (existingActivity == null)
			{
				throw new Exception($"No activity found: {activity}");
			}

			existingActivity = activity;
			existingActivity.UpdatedAt = DateTime.Now;
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
