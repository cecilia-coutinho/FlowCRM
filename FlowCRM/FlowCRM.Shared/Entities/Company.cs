using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCRM.Shared.Entities
{
		public class Company
		{
				public Guid CompanyId { get; set; }
				public required string CompanyName { get; set; }
				public string? CompanyAddress { get; set; }
				public string? CompanyEmailAddress { get; set; }
				public string? CompanyPhoneNumber { get; set; }
				public string? City { get; set; }
				public string? Country { get; set; }
				public DateTime? CreatedAt { get; set; }
				public DateTime? UpdatedAt { get; set; }
				public Guid? CreatedBy { get; set; }
				public Guid? UpdatedBy { get; set; }
		}
}
