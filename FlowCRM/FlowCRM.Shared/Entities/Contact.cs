namespace FlowCRM.Shared.Entities
{
    public class Contact
    {
        public Guid ContactId { get; set; }
        public Guid? FkCustomerId { get; set; }
        public Guid? FkCompanyId { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }

        // Navigation properties FKs
        public virtual Customer? Customers { get; set; }
        public virtual Company? Companies { get; set; }

    }
}
