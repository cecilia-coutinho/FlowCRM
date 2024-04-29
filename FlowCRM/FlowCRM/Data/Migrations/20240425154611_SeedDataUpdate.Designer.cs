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
    [Migration("20240425154611_SeedDataUpdate")]
    partial class SeedDataUpdate
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

                    b.HasData(
                        new
                        {
                            ActivityTypeId = new Guid("5b65182d-c62c-41bf-961c-af3e44e779d2"),
                            TypeName = "Call"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("943fe237-8bc5-4ccc-8aee-cdf47f2cbbac"),
                            TypeName = "Meeting"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("6f03e807-1aef-41a3-9d31-929c9df658c6"),
                            TypeName = "Email"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("d3d9d09b-cabb-4e8d-bcf8-8bbf9e183dc6"),
                            TypeName = "Task"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("5a55fb70-5698-4d95-8b1f-f600b3ff6107"),
                            TypeName = "Note"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("9ff39f91-d2d2-4f89-be98-8023b7c85d01"),
                            TypeName = "Other"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("d8e92620-1647-4af8-a89a-7588efd8f9f0"),
                            TypeName = "Follow-up"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("c948bd90-e3eb-46b9-a97e-bc539f9cb14c"),
                            TypeName = "Demo"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("32c0fa65-169b-4f21-b147-77e2b641311d"),
                            TypeName = "Presentation"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("038fcd9e-79a1-4720-9bec-d2bd8cdba0d8"),
                            TypeName = "Training"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("0c25d441-3602-4e43-b6ff-ecd513e1b308"),
                            TypeName = "Webinar"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("10275ae0-4c95-47bd-9fbe-a402bcb3a883"),
                            TypeName = "Workshop"
                        });
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
                            CompanyId = new Guid("1774118b-289c-451d-a202-3f8a80ba07f4"),
                            City = "Redmond",
                            CompanyAddress = "Redmond, Washington",
                            CompanyEmailAddress = "microsoft.example@example.com",
                            CompanyName = "Microsoft",
                            CompanyPhoneNumber = "123456789",
                            Country = "USA",
                            CreatedAt = new DateTime(2024, 4, 25, 17, 46, 10, 862, DateTimeKind.Local).AddTicks(4018)
                        },
                        new
                        {
                            CompanyId = new Guid("bc0050f8-a7fa-4f7d-b431-f9a6c1eb5017"),
                            City = "Cupertino",
                            CompanyAddress = "Cupertino, California",
                            CompanyEmailAddress = "apple.example@example.com",
                            CompanyName = "Apple",
                            CompanyPhoneNumber = "123456780",
                            Country = "USA",
                            CreatedAt = new DateTime(2024, 4, 25, 17, 46, 10, 862, DateTimeKind.Local).AddTicks(4022)
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
                            ContactId = new Guid("d2881f72-9888-4179-9c57-75a93d33566a"),
                            CreatedAt = new DateTime(2024, 4, 25, 17, 46, 10, 862, DateTimeKind.Local).AddTicks(4045),
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
                            CustomerId = new Guid("eb3c7d07-3ba0-46d6-9711-0a77d72587c7"),
                            City = "New York",
                            Country = "USA",
                            CreatedAt = new DateTime(2024, 4, 25, 17, 46, 10, 862, DateTimeKind.Local).AddTicks(3771),
                            Email = "john.doe@example.com",
                            FirstName = "John",
                            LastName = "Doe",
                            PhoneNumber = "123456789"
                        },
                        new
                        {
                            CustomerId = new Guid("97b59b37-f243-42be-8310-a77af427517f"),
                            City = "California",
                            Country = "USA",
                            CreatedAt = new DateTime(2024, 4, 25, 17, 46, 10, 862, DateTimeKind.Local).AddTicks(3862),
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

                    b.HasData(
                        new
                        {
                            PriorityId = new Guid("0e04c361-8422-439b-aa6a-edcfd0097b08"),
                            PriorityName = "Low"
                        },
                        new
                        {
                            PriorityId = new Guid("80ccde9c-7998-4138-891a-a79e8384d166"),
                            PriorityName = "Medium"
                        },
                        new
                        {
                            PriorityId = new Guid("6850bf64-9483-4de2-8728-d292696ce0d5"),
                            PriorityName = "High"
                        },
                        new
                        {
                            PriorityId = new Guid("686b928d-2584-4a97-87fc-d8ef4c2c6141"),
                            PriorityName = "Urgent"
                        });
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
