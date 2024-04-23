using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCRM.Shared.Entities
{
		public class Priority
		{
				public Guid PriorityId { get; set; }
				public required string PriorityName { get; set; }
		}
}
