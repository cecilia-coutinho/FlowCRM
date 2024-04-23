using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCRM.Shared.Entities
{
		public class Deal
		{
				public Guid DealId { get; set; }
				public Guid CustomerId { get; set; }
				public Guid CompanyId { get; set; }
				public required decimal DealAmount { get; set; }
				public required Guid DealStatusId { get; set; }
				public required Guid PriorityId { get; set; }
				public DateTime? CreatedAt { get; set; }
				public DateTime? UpdatedAt { get; set; }
				public Guid? CreatedBy { get; set; }
				public Guid? UpdatedBy { get; set; }
		}
}