using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCRM.Shared.Entities
{
		public class ActivityType
		{
				public Guid ActivityTypeId { get; set; }
				public required string TypeName { get; set; }
		}
}
