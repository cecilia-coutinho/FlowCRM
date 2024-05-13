using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FlowCRM.Shared.Entities
{
    public class DealStatus
    {
        [Key]
        public Guid DealStatusId { get; set; }

        [Required]
        public string? StatusName { get; set; }

        // Navigation properties
        [JsonIgnore]
        public ICollection<Deal>? Deals { get; set; }
    }
}
