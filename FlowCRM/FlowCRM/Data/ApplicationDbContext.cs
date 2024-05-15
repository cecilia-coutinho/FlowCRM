using FlowCRM.Shared.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;

namespace FlowCRM.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<ActivityType> ActivitiesType { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Deal> Deals { get; set; }
        public DbSet<DealStatus> DealsStatus { get; set; }
        public DbSet<Lead> Leads { get; set; }
        public DbSet<Priority> Priorities { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustomerId);
                entity.HasIndex(e => e.Email).IsUnique();
            });

            builder.Entity<Priority>(entity =>
            {
                entity.HasKey(e => e.PriorityId);
                entity.HasIndex(e => e.PriorityName).IsUnique();
            });

            builder.Entity<DealStatus>(entity =>
            {
                entity.HasKey(e => e.DealStatusId);
                entity.HasIndex(e => e.StatusName).IsUnique();
            });

            builder.Entity<Company>(entity =>
            {
                entity.HasKey(e => e.CompanyId);
                entity.HasIndex(e => e.CompanyName).IsUnique();
                entity.HasIndex(e => e.CompanyEmailAddress).IsUnique();
            });

            builder.Entity<Activity>(entity =>
            {
                entity.HasKey(a => a.ActivityId);
                entity.HasOne(a => a.Deals).WithMany(d => d.Activities).HasForeignKey(a => a.FkDealId);
                entity.HasOne(a => a.ActivitiesType).WithMany(at => at.Activities).HasForeignKey(a => a.FkActivityTypeId);
            });

            builder.Entity<ActivityType>(entity =>
            {
                entity.HasKey(e => e.ActivityTypeId);
                entity.HasIndex(e => e.TypeName).IsUnique();
            });

            builder.Entity<Contact>(entity =>
            {
                entity.HasKey(e => e.ContactId);
                entity.HasIndex(e => e.Email).IsUnique();
                entity.HasOne(e => e.Customers).WithMany(c => c.Contacts).HasForeignKey(e => e.FkCustomerId);
                entity.HasOne(e => e.Companies).WithMany(c => c.Contacts).HasForeignKey(e => e.FkCompanyId).OnDelete(DeleteBehavior.Cascade);
            });

            builder.Entity<Deal>(entity =>
            {
                entity.HasKey(e => e.DealId);
                entity.HasIndex(e => e.DealName).IsUnique();
                entity.Property(e => e.DealAmount).HasColumnType("decimal(18,2)");
                entity.HasOne(e => e.Customers).WithMany(c => c.Deals).HasForeignKey(e => e.FkCustomerId);
                entity.HasOne(e => e.Companies).WithMany(c => c.Deals).HasForeignKey(e => e.FkCompanyId);
                entity.HasOne(e => e.Priorities).WithMany(p => p.Deals).HasForeignKey(e => e.FkPriorityId);
                entity.HasOne(e => e.DealsStatus).WithMany(ds => ds.Deals).HasForeignKey(e => e.FkDealStatusId);

            });

            builder.Entity<Lead>(entity =>
            {
                entity.HasKey(e => e.LeadId);
                entity.HasOne(e => e.Companies).WithMany(c => c.Leads).HasForeignKey(e => e.FkCompanyId);
                entity.HasOne(e => e.Priorities).WithMany(p => p.Leads).HasForeignKey(e => e.FkPriorityId);
            });


            builder.Entity<Customer>().HasData(
            new Customer
            {
                CustomerId = Guid.NewGuid(),
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                PhoneNumber = "123456789",
                City = "New York",
                Country = "USA",
                CreatedAt = DateTime.Now
            },
            new Customer
            {
                CustomerId = Guid.NewGuid(),
                FirstName = "Maria",
                LastName = "Rosa",
                Email = "maria.rosa@example.com",
                PhoneNumber = "123456780",
                City = "California",
                Country = "USA",
                CreatedAt = DateTime.Now
            });

            builder.Entity<Company>().HasData(
            new Company
            {
                CompanyId = Guid.NewGuid(),
                CompanyName = "Microsoft",
                CompanyAddress = "Redmond, Washington",
                CompanyEmailAddress = "microsoft.example@example.com",
                CompanyPhoneNumber = "123456789",
                City = "Redmond",
                Country = "USA",
                CreatedAt = DateTime.Now
            },
            new Company
            {
                CompanyId = Guid.NewGuid(),
                CompanyName = "Apple",
                CompanyAddress = "Cupertino, California",
                CompanyEmailAddress = "apple.example@example.com",
                CompanyPhoneNumber = "123456780",
                City = "Cupertino",
                Country = "USA",
                CreatedAt = DateTime.Now
            });

            builder.Entity<Contact>().HasData(
            new Contact
            {
                ContactId = Guid.NewGuid(),
                FirstName = "Anna",
                LastName = "Banana",
                Email = "anna.banana@example.com",
                PhoneNumber = "123456789",
                CreatedAt = DateTime.Now
            });

            var activityTypes = new[] { "Call", "Meeting", "Email", "Task", "Note", "Other", "Follow-up", "Demo", "Presentation", "Training", "Webinar", "Workshop" };

            foreach (var typeName in activityTypes)
            {
                builder.Entity<ActivityType>().HasData(new ActivityType
                {
                    ActivityTypeId = Guid.NewGuid(),
                    TypeName = typeName
                });
            }

            var priorities = new[] { "Low", "Medium", "High", "Urgent" };

            foreach (var priorityName in priorities)
            {
                builder.Entity<Priority>().HasData(new Priority
                {
                    PriorityId = Guid.NewGuid(),
                    PriorityName = priorityName
                });
            }

            var dealStatuses = new[] { "New", "In Progress", "Closed Won", "Closed Lost", "On Hold" };

            foreach (var statusName in dealStatuses)
            {
                builder.Entity<DealStatus>().HasData(new DealStatus
                {
                    DealStatusId = Guid.NewGuid(),
                    StatusName = statusName
                });
            }

        }
    }

}
