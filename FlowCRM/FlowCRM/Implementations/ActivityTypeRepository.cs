using FlowCRM.Data;
using FlowCRM.Shared.Entities;
using FlowCRM.Shared.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FlowCRM.Implementations
{
		public class ActivityTypeRepository : IActivityTypeRepository
		{
				private readonly ApplicationDbContext _context;

				public ActivityTypeRepository(ApplicationDbContext context)
				{
						_context = context;
				}
				public async Task<IEnumerable<ActivityType>> GetActivitiesTypeAsync()
				{
						return await _context.ActivitiesType.ToListAsync();
				}

				public async Task<ActivityType> GetActivityTypeAsync(Guid id)
				{
						var activityType = await _context.ActivitiesType.FindAsync(id);

						if (activityType == null)
						{
								throw new Exception($"No activity type found with ID {id}");
						}

						return activityType;
				}

		}
}
