using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCRM.Shared.Entities
{
		public class DealStatus
		{
				public Guid DealStatusId { get; set; }
				public required string StatusName { get; set; }
		}
}
