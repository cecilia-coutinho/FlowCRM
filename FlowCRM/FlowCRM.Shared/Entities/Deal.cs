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
				public string? DealName { get; set; }
				public Guid? FkCustomerId { get; set; }
				public Guid? FkCompanyId { get; set; }
				public required decimal DealAmount { get; set; }
				public required Guid FkDealStatusId { get; set; }
				public required Guid FkPriorityId { get; set; }
				public DateTime? CreatedAt { get; set; }
				public DateTime? UpdatedAt { get; set; }
				public string? CreatedBy { get; set; }
				public string? UpdatedBy { get; set; }

				// Navigation properties
				public ICollection<Activity>? Activities { get; set; }
				public virtual Customer? Customers { get; set; }
				public virtual Company? Companies { get; set; }
				public virtual DealStatus? DealsStatus { get; set; }
				public virtual Priority? Priorities { get; set; }
		}
}