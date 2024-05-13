using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FlowCRM.Shared.Entities
{
    public class Priority
    {
        [Key]
        public Guid PriorityId { get; set; }

        [Required]
        public string? PriorityName { get; set; }

        // Navigation properties
        [JsonIgnore]
        public ICollection<Deal>? Deals { get; set; }
        [JsonIgnore]
        public ICollection<Lead>? Leads { get; set; }
    }
}
