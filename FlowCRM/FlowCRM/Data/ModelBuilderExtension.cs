using FlowCRM.Shared.Entities;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;

namespace FlowCRM.Data
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
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

            modelBuilder.Entity<Company>().HasData(
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

            modelBuilder.Entity<Contact>().HasData(
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
                modelBuilder.Entity<ActivityType>().HasData(new ActivityType
                {
                    ActivityTypeId = Guid.NewGuid(),
                    TypeName = typeName
                });
            }

            var priorities = new[] { "Low", "Medium", "High", "Urgent" };

            foreach (var priorityName in priorities)
            {
                modelBuilder.Entity<Priority>().HasData(new Priority
                {
                    PriorityId = Guid.NewGuid(),
                    PriorityName = priorityName
                });
            }

            var dealStatuses = new[] { "New", "In Progress", "Closed Won", "Closed Lost", "On Hold" };

            foreach (var statusName in dealStatuses)
            {
                modelBuilder.Entity<DealStatus>().HasData(new DealStatus
                {
                    DealStatusId = Guid.NewGuid(),
                    StatusName = statusName
                });
            }
        }
    }
}
