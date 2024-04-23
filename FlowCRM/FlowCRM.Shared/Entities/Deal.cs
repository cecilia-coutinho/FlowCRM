using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCRM.Shared.Entities
{
		public class Deal
		{
				public Guid DealId { get; set; }

				[ForeignKey("Customer")]
				public Guid? CustomerId { get; set; }
				public Customer? Customer { get; set; }

				[ForeignKey("Company")]
				public Guid? CompanyId { get; set; }
				public Company? Company { get; set; }

				public required decimal DealAmount { get; set; }

				[ForeignKey("DealStatus")]
				public required Guid DealStatusId { get; set; }
				public DealStatus? DealStatus { get; set; }

				[ForeignKey("Priority")]
				public required Guid PriorityId { get; set; }
				public Priority? Priority { get; set; }

				public DateTime? CreatedAt { get; set; }
				public DateTime? UpdatedAt { get; set; }
				public Guid? CreatedBy { get; set; }
				public Guid? UpdatedBy { get; set; }
		}
}