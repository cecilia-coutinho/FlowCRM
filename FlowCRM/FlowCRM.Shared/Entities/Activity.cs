using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FlowCRM.Shared.Entities
{
    public class Activity
    {
        public Guid ActivityId { get; set; }
        public Guid? FkDealId { get; set; }
        public Guid? FkActivityTypeId { get; set; }
        public string? ActivityNote { get; set; }
        public DateOnly ActivityDate { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }


        // Navigation properties FKs
        [JsonIgnore]
        public virtual Deal? Deals { get; set; }
        [JsonIgnore]
        public virtual ActivityType? ActivitiesType { get; set; }
    }
}