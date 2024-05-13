using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FlowCRM.Shared.Entities
{
    public class Company
    {
        [Key]
        public Guid CompanyId { get; set; }

        [Required]
        public string? CompanyName { get; set; }
        public string? CompanyAddress { get; set; }
        public string? CompanyEmailAddress { get; set; }
        public string? CompanyPhoneNumber { get; set; }
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
        [JsonIgnore]
        public ICollection<Lead>? Leads { get; set; }
    }
}
