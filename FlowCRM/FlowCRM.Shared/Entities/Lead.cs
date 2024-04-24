﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCRM.Shared.Entities
{
		public class Lead
		{
				public Guid LeadId { get; set; }
				public required string FirstName { get; set; }
				public required string LastName { get; set; }
				public required string Email { get; set; }
				public string? PhoneNumber { get; set; }
				public Guid? FkPriorityId { get; set; }
				public Guid? FkCompanyId { get; set; }
				public DateTime? CreatedAt { get; set; }
				public DateTime? UpdatedAt { get; set; }
				public Guid? CreatedBy { get; set; }
				public Guid? UpdatedBy { get; set; }

				// Navigation properties
				public virtual Priority? Priorities { get; set; }
				public virtual Company? Companies { get; set; }
		}
}
