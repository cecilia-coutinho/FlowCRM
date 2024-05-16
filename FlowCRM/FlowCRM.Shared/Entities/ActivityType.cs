using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FlowCRM.Shared.Entities
{
    public class ActivityType
    {

        [Key]
        public Guid ActivityTypeId { get; set; }

        [Required]
        public string? TypeName { get; set; }

        [JsonIgnore]
        public ICollection<Activity>? Activities { get; set; }
    }
}
