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

				// Navigation properties
				public ICollection<Deal>? Deals { get; set; }
				public ICollection<Lead>? Leads { get; set; }
		}
}
