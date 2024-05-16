using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FlowCRM.Shared.Entities
{
    public class Deal
    {
        [Key]
        public Guid DealId { get; set; }
        public string? DealName { get; set; }
        public Guid? FkCustomerId { get; set; }
        public Guid? FkCompanyId { get; set; }

        [Required]
        public decimal DealAmount { get; set; }

        [Required]
        public Guid FkDealStatusId { get; set; }

        [Required]
        public Guid FkPriorityId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }

        // Navigation properties
        [JsonIgnore]
        public ICollection<Activity>? Activities { get; set; }
        [JsonIgnore]
        public virtual Customer? Customers { get; set; }
        [JsonIgnore]
        public virtual Company? Companies { get; set; }
        [JsonIgnore]
        public virtual DealStatus? DealsStatus { get; set; }
        [JsonIgnore]
        public virtual Priority? Priorities { get; set; }
    }
}