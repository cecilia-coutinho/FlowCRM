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

				[ForeignKey("Deal")]
				public Guid DealId { get; set; }
				public Deal? Deal { get; set; }

				[ForeignKey("ActivityType")]
				public Guid ActivityTypeId { get; set; }
				public ActivityType? ActivityType { get; set; }

				public string? ActivityNote { get; set; }
				public required DateTime ActivityDate { get; set; }
				public DateTime? CreatedAt { get; set; }
				public DateTime? UpdatedAt { get; set; }
				public Guid? CreatedBy { get; set; }
				public Guid? UpdatedBy { get; set; }
		}
}