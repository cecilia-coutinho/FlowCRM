using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FlowCRM.Shared.Entities
{
    public class Lead
    {
        [Key]
        public Guid LeadId { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        public string? Email { get; set; }

        public string? PhoneNumber { get; set; }
        public Guid? FkPriorityId { get; set; }
        public Guid? FkCompanyId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }

        // Navigation properties
        public virtual Priority? Priorities { get; set; }
        public virtual Company? Companies { get; set; }
    }
}
