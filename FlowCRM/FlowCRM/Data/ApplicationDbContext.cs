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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustomerId);
                entity.HasIndex(e => e.Email).IsUnique();
            });

            modelBuilder.Entity<Priority>(entity =>
            {
                entity.HasKey(e => e.PriorityId);
                entity.HasIndex(e => e.PriorityName).IsUnique();
            });

            modelBuilder.Entity<DealStatus>(entity =>
            {
                entity.HasKey(e => e.DealStatusId);
                entity.HasIndex(e => e.StatusName).IsUnique();
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasKey(e => e.CompanyId);
                entity.HasIndex(e => e.CompanyName).IsUnique();
                entity.HasIndex(e => e.CompanyEmailAddress).IsUnique();
            });

            modelBuilder.Entity<Activity>(entity =>
            {
                entity.HasKey(a => a.ActivityId);
                entity.HasOne(a => a.Deals).WithMany(d => d.Activities).HasForeignKey(a => a.FkDealId);
                entity.HasOne(a => a.ActivitiesType).WithMany(at => at.Activities).HasForeignKey(a => a.FkActivityTypeId);
            });

            modelBuilder.Entity<ActivityType>(entity =>
            {
                entity.HasKey(e => e.ActivityTypeId);
                entity.HasIndex(e => e.TypeName).IsUnique();
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasKey(e => e.ContactId);
                entity.HasIndex(e => e.Email).IsUnique();
                entity.HasOne(e => e.Customers).WithMany(c => c.Contacts).HasForeignKey(e => e.FkCustomerId);
                entity.HasOne(e => e.Companies).WithMany(c => c.Contacts).HasForeignKey(e => e.FkCompanyId).OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Deal>(entity =>
            {
                entity.HasKey(e => e.DealId);
                entity.HasIndex(e => e.DealName).IsUnique();
                entity.Property(e => e.DealAmount).HasColumnType("decimal(18,2)");
                entity.HasOne(e => e.Customers).WithMany(c => c.Deals).HasForeignKey(e => e.FkCustomerId);
                entity.HasOne(e => e.Companies).WithMany(c => c.Deals).HasForeignKey(e => e.FkCompanyId);
                entity.HasOne(e => e.Priorities).WithMany(p => p.Deals).HasForeignKey(e => e.FkPriorityId);
                entity.HasOne(e => e.DealsStatus).WithMany(ds => ds.Deals).HasForeignKey(e => e.FkDealStatusId);

            });

            modelBuilder.Entity<Lead>(entity =>
            {
                entity.HasKey(e => e.LeadId);
                entity.HasOne(e => e.Companies).WithMany(c => c.Leads).HasForeignKey(e => e.FkCompanyId).OnDelete(DeleteBehavior.Cascade);
                entity.HasOne(e => e.Priorities).WithMany(p => p.Leads).HasForeignKey(e => e.FkPriorityId).OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Seed();
        }
    }

}
