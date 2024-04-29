using FlowCRM.Shared.Entities;

namespace FlowCRM.Shared.Repositories
{
	public interface IActivityRepository
	{
		Task<IEnumerable<Activity>> GetActivitiesAsync();
		Task<Activity> GetActivityAsync(Guid id);
		Task<Activity> AddActivityAsync(Activity activity);
		Task<Activity> UpdateActivityAsync(Activity activity);
		Task<Activity> DeleteActivityAsync(Guid id);
	}
}
