using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FlowCRM.Shared.Entities
{
    public class Customer
    {
        [Key]
        public Guid CustomerId { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }

        // Navigation properties
        [JsonIgnore]
        public ICollection<Contact>? Contacts { get; set; }
        [JsonIgnore]
        public ICollection<Deal>? Deals { get; set; }

    }
}
