using FlowCRM.Shared.Entities;

namespace FlowCRM.Shared.Repositories
{
	public interface IActivityRepository
	{
		Task<IEnumerable<Activity>> GetActivitiesAsync(string? filterOn = null, string? filterQuery = null, string? sortBy = null, bool isAscending = true, int pageNumber = 1, int pageSize = 1000);
		Task<Activity> GetActivityAsync(Guid id);
		Task<Activity> AddActivityAsync(Activity activity);
		Task<Activity> UpdateActivityAsync(Activity activity);
		Task<Activity> DeleteActivityAsync(Guid id);
	}
}
