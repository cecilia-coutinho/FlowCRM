﻿// <auto-generated />
using System;
using FlowCRM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FlowCRM.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240425123702_SeedDataAdded")]
    partial class SeedDataAdded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FlowCRM.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SocialSecurityNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("FlowCRM.Shared.Entities.Activity", b =>
                {
                    b.Property<Guid>("ActivityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ActivityDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ActivityNote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FkActivityTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FkDealId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ActivityId");

                    b.HasIndex("FkActivityTypeId");

                    b.HasIndex("FkDealId");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("FlowCRM.Shared.Entities.ActivityType", b =>
                {
                    b.Property<Guid>("ActivityTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ActivityTypeId");

                    b.HasIndex("TypeName")
                        .IsUnique();

                    b.ToTable("ActivitiesType");
                });

            modelBuilder.Entity("FlowCRM.Shared.Entities.Company", b =>
                {
                    b.Property<Guid>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyEmailAddress")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CompanyPhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CompanyId");

                    b.HasIndex("CompanyEmailAddress")
                        .IsUnique()
                        .HasFilter("[CompanyEmailAddress] IS NOT NULL");

                    b.HasIndex("CompanyName")
                        .IsUnique();

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            CompanyId = new Guid("209e87dc-d5fb-4b2d-b642-e94da30411b7"),
                            City = "Redmond",
                            CompanyAddress = "Redmond, Washington",
                            CompanyEmailAddress = "microsoft.example@example.com",
                            CompanyName = "Microsoft",
                            CompanyPhoneNumber = "123456789",
                            Country = "USA",
                            CreatedAt = new DateTime(2024, 4, 25, 14, 37, 1, 509, DateTimeKind.Local).AddTicks(6046)
                        },
                        new
                        {
                            CompanyId = new Guid("053709a9-73b8-42fd-bd1e-6782e1a67d55"),
                            City = "Cupertino",
                            CompanyAddress = "Cupertino, California",
                            CompanyEmailAddress = "apple.example@example.com",
                            CompanyName = "Apple",
                            CompanyPhoneNumber = "123456780",
                            Country = "USA",
                            CreatedAt = new DateTime(2024, 4, 25, 14, 37, 1, 509, DateTimeKind.Local).AddTicks(6049)
                        });
                });

            modelBuilder.Entity("FlowCRM.Shared.Entities.Contact", b =>
                {
                    b.Property<Guid>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("FkCompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("FkCustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ContactId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("FkCompanyId");

                    b.HasIndex("FkCustomerId");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            ContactId = new Guid("ea79b95a-7f0b-44a5-b6bb-279f3750faaf"),
                            CreatedAt = new DateTime(2024, 4, 25, 14, 37, 1, 509, DateTimeKind.Local).AddTicks(6074),
                            Email = "anna.banana@example.com",
                            FirstName = "Anna",
                            LastName = "Banana",
                            PhoneNumber = "123456789"
                        });
                });

            modelBuilder.Entity("FlowCRM.Shared.Entities.Customer", b =>
                {
                    b.Property<Guid>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CustomerId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = new Guid("836d8bca-c975-4425-bea5-39ec059012bf"),
                            City = "New York",
                            Country = "USA",
                            CreatedAt = new DateTime(2024, 4, 25, 14, 37, 1, 509, DateTimeKind.Local).AddTicks(5898),
                            Email = "john.doe@example.com",
                            FirstName = "John",
                            LastName = "Doe",
                            PhoneNumber = "123456789"
                        },
                        new
                        {
                            CustomerId = new Guid("0f362275-9ad5-460d-a931-1eb25726939f"),
                            City = "California",
                            Country = "USA",
                            CreatedAt = new DateTime(2024, 4, 25, 14, 37, 1, 509, DateTimeKind.Local).AddTicks(5950),
                            Email = "maria.rosa@example.com",
                            FirstName = "Maria",
                            LastName = "Rosa",
                            PhoneNumber = "123456780"
                        });
                });

            modelBuilder.Entity("FlowCRM.Shared.Entities.Deal", b =>
                {
                    b.Property<Guid>("DealId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("DealAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("FkCompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("FkCustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FkDealStatusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FkPriorityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("DealId");

                    b.HasIndex("FkCompanyId");

                    b.HasIndex("FkCustomerId");

                    b.HasIndex("FkDealStatusId");

                    b.HasIndex("FkPriorityId");

                    b.ToTable("Deals");
                });

            modelBuilder.Entity("FlowCRM.Shared.Entities.DealStatus", b =>
                {
                    b.Property<Guid>("DealStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("DealStatusId");

                    b.HasIndex("StatusName")
                        .IsUnique();

                    b.ToTable("DealsStatus");
                });

            modelBuilder.Entity("FlowCRM.Shared.Entities.Lead", b =>
                {
                    b.Property<Guid>("LeadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("FkCompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("FkPriorityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LeadId");

                    b.HasIndex("FkCompanyId");

                    b.HasIndex("FkPriorityId");

                    b.ToTable("Leads");
                });

            modelBuilder.Entity("FlowCRM.Shared.Entities.Priority", b =>
                {
                    b.Property<Guid>("PriorityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PriorityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PriorityId");

                    b.HasIndex("PriorityName")
                        .IsUnique();

                    b.ToTable("Priorities");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("FlowCRM.Shared.Entities.Activity", b =>
                {
                    b.HasOne("FlowCRM.Shared.Entities.ActivityType", "ActivitiesType")
                        .WithMany("Activities")
                        .HasForeignKey("FkActivityTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FlowCRM.Shared.Entities.Deal", "Deals")
                        .WithMany("Activities")
                        .HasForeignKey("FkDealId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ActivitiesType");

                    b.Navigation("Deals");
                });

            modelBuilder.Entity("FlowCRM.Shared.Entities.Contact", b =>
                {
                    b.HasOne("FlowCRM.Shared.Entities.Company", "Companies")
                        .WithMany("Contacts")
                        .HasForeignKey("FkCompanyId");

                    b.HasOne("FlowCRM.Shared.Entities.Customer", "Customers")
                        .WithMany("Contacts")
                        .HasForeignKey("FkCustomerId");

                    b.Navigation("Companies");

                    b.Navigation("Customers");
                });

            modelBuilder.Entity("FlowCRM.Shared.Entities.Deal", b =>
                {
                    b.HasOne("FlowCRM.Shared.Entities.Company", "Companies")
                        .WithMany("Deals")
                        .HasForeignKey("FkCompanyId");

                    b.HasOne("FlowCRM.Shared.Entities.Customer", "Customers")
                        .WithMany("Deals")
                        .HasForeignKey("FkCustomerId");

                    b.HasOne("FlowCRM.Shared.Entities.DealStatus", "DealsStatus")
                        .WithMany("Deals")
                        .HasForeignKey("FkDealStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FlowCRM.Shared.Entities.Priority", "Priorities")
                        .WithMany("Deals")
                        .HasForeignKey("FkPriorityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Companies");

                    b.Navigation("Customers");

                    b.Navigation("DealsStatus");

                    b.Navigation("Priorities");
                });

            modelBuilder.Entity("FlowCRM.Shared.Entities.Lead", b =>
                {
                    b.HasOne("FlowCRM.Shared.Entities.Company", "Companies")
                        .WithMany("Leads")
                        .HasForeignKey("FkCompanyId");

                    b.HasOne("FlowCRM.Shared.Entities.Priority", "Priorities")
                        .WithMany("Leads")
                        .HasForeignKey("FkPriorityId");

                    b.Navigation("Companies");

                    b.Navigation("Priorities");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("FlowCRM.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("FlowCRM.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FlowCRM.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("FlowCRM.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FlowCRM.Shared.Entities.ActivityType", b =>
                {
                    b.Navigation("Activities");
                });

            modelBuilder.Entity("FlowCRM.Shared.Entities.Company", b =>
                {
                    b.Navigation("Contacts");

                    b.Navigation("Deals");

                    b.Navigation("Leads");
                });

            modelBuilder.Entity("FlowCRM.Shared.Entities.Customer", b =>
                {
                    b.Navigation("Contacts");

                    b.Navigation("Deals");
                });

            modelBuilder.Entity("FlowCRM.Shared.Entities.Deal", b =>
                {
                    b.Navigation("Activities");
                });

            modelBuilder.Entity("FlowCRM.Shared.Entities.DealStatus", b =>
                {
                    b.Navigation("Deals");
                });

            modelBuilder.Entity("FlowCRM.Shared.Entities.Priority", b =>
                {
                    b.Navigation("Deals");

                    b.Navigation("Leads");
                });
#pragma warning restore 612, 618
        }
    }
}
