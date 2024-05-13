using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FlowCRM.Shared.Entities
{
    public class Contact
    {
        [Key]
        public Guid ContactId { get; set; }
        public Guid? FkCustomerId { get; set; }
        public Guid? FkCompanyId { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }

        // Navigation properties FKs
        [JsonIgnore]
        public virtual Customer? Customers { get; set; }
        [JsonIgnore]
        public virtual Company? Companies { get; set; }

    }
}
