using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCRM.Shared.Entities
{
		public class Activity
		{
				public Guid ActivityId { get; set; }
				public Guid FkDealId { get; set; }
				public Guid FkActivityTypeId { get; set; }
				public string? ActivityNote { get; set; }
				public required DateTime ActivityDate { get; set; }
				public DateTime? CreatedAt { get; set; }
				public DateTime? UpdatedAt { get; set; }
				public Guid? CreatedBy { get; set; }
				public Guid? UpdatedBy { get; set; }

				// Navigation properties FKs
				public virtual Deal? Deals { get; set; }
				public virtual ActivityType? ActivitiesType { get; set; }
		}
}