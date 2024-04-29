using FlowCRM.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCRM.Shared.Repositories
{
		public interface IActivityTypeRepository
		{
				Task<IEnumerable<ActivityType>> GetActivitiesTypeAsync();
				Task<ActivityType> GetActivityTypeAsync(Guid id);
		}
}
