﻿// <auto-generated />
using System;
using FlowCRM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FlowCRM.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<DateOnly>("ActivityDate")
                        .HasColumnType("date");

                    b.Property<string>("ActivityNote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("FkActivityTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("FkDealId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

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
                            ActivityTypeId = new Guid("410a155b-648d-4532-b8d7-f8c57b194e99"),
                            TypeName = "Call"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("22487027-344a-4714-a2eb-28250b08f362"),
                            TypeName = "Meeting"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("a553f8e9-fcf1-46a0-b061-072addc54bbd"),
                            TypeName = "Email"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("1a77d3ab-fce4-4967-9082-5af151b7ae40"),
                            TypeName = "Task"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("2a967bfd-e4fb-4b7a-9572-98f3cea10459"),
                            TypeName = "Note"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("dc9c632b-d7bb-4eed-99e2-afbfe8646660"),
                            TypeName = "Other"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("7c565f4d-4fb9-4ea2-a709-960fe2bab84b"),
                            TypeName = "Follow-up"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("89d96187-3d59-43db-8f72-96481f9fa2e6"),
                            TypeName = "Demo"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("2e0d53b2-19cc-423e-86b6-674a7f88ca16"),
                            TypeName = "Presentation"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("81e3f7e5-aa3d-465d-8fb6-8678cc2d3811"),
                            TypeName = "Training"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("138025a3-f2f1-40be-a0c6-343e2cc4cf47"),
                            TypeName = "Webinar"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("ed918e26-a0a1-4c5f-84be-c17fef05a41a"),
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

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

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
                            CompanyId = new Guid("319f7972-975d-4f74-9dd9-6cdb64e1288c"),
                            City = "Redmond",
                            CompanyAddress = "Redmond, Washington",
                            CompanyEmailAddress = "microsoft.example@example.com",
                            CompanyName = "Microsoft",
                            CompanyPhoneNumber = "123456789",
                            Country = "USA",
                            CreatedAt = new DateTime(2024, 5, 20, 18, 12, 53, 435, DateTimeKind.Local).AddTicks(5975)
                        },
                        new
                        {
                            CompanyId = new Guid("9cf715b9-22bf-42c3-a861-eef805f9efaa"),
                            City = "Cupertino",
                            CompanyAddress = "Cupertino, California",
                            CompanyEmailAddress = "apple.example@example.com",
                            CompanyName = "Apple",
                            CompanyPhoneNumber = "123456780",
                            Country = "USA",
                            CreatedAt = new DateTime(2024, 5, 20, 18, 12, 53, 435, DateTimeKind.Local).AddTicks(5982)
                        });
                });

            modelBuilder.Entity("FlowCRM.Shared.Entities.Contact", b =>
                {
                    b.Property<Guid>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("FkCompanyId");

                    b.HasIndex("FkCustomerId");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            ContactId = new Guid("7d600c24-b47e-4fba-9abd-d1aed29359f9"),
                            CreatedAt = new DateTime(2024, 5, 20, 18, 12, 53, 435, DateTimeKind.Local).AddTicks(6027),
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

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = new Guid("bbb14bc5-d728-4dac-99bb-4fe3f632a0ec"),
                            City = "New York",
                            Country = "USA",
                            CreatedAt = new DateTime(2024, 5, 20, 18, 12, 53, 435, DateTimeKind.Local).AddTicks(5613),
                            Email = "john.doe@example.com",
                            FirstName = "John",
                            LastName = "Doe",
                            PhoneNumber = "123456789"
                        },
                        new
                        {
                            CustomerId = new Guid("99d179cd-7069-4554-ad6a-2ed698dc590e"),
                            City = "California",
                            Country = "USA",
                            CreatedAt = new DateTime(2024, 5, 20, 18, 12, 53, 435, DateTimeKind.Local).AddTicks(5687),
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

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("DealAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("DealName")
                        .HasColumnType("nvarchar(450)");

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

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DealId");

                    b.HasIndex("DealName")
                        .IsUnique()
                        .HasFilter("[DealName] IS NOT NULL");

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

                    b.HasData(
                        new
                        {
                            DealStatusId = new Guid("51fc8580-1a6e-4167-9c70-07e0fece4d7e"),
                            StatusName = "New"
                        },
                        new
                        {
                            DealStatusId = new Guid("9fbb2096-d69e-4d8c-a4cd-c856ac7d0718"),
                            StatusName = "In Progress"
                        },
                        new
                        {
                            DealStatusId = new Guid("03c2b1a2-fbb1-4ea8-926c-69d1f5a2e455"),
                            StatusName = "Closed Won"
                        },
                        new
                        {
                            DealStatusId = new Guid("40f313d2-8d9c-40a7-aef5-aed36e888a53"),
                            StatusName = "Closed Lost"
                        },
                        new
                        {
                            DealStatusId = new Guid("dad77172-0c5f-4bff-a15c-0860fd0ed9e7"),
                            StatusName = "On Hold"
                        });
                });

            modelBuilder.Entity("FlowCRM.Shared.Entities.Lead", b =>
                {
                    b.Property<Guid>("LeadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

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
                            PriorityId = new Guid("1a06fe68-189e-41ba-b821-0d1de8b684f2"),
                            PriorityName = "Low"
                        },
                        new
                        {
                            PriorityId = new Guid("8bd04657-9a6f-4bed-889c-d245389b80c8"),
                            PriorityName = "Medium"
                        },
                        new
                        {
                            PriorityId = new Guid("c72fb504-4922-4ebd-a65d-e8e68eb30cd1"),
                            PriorityName = "High"
                        },
                        new
                        {
                            PriorityId = new Guid("13cd3827-dfa2-4b58-aa85-76f2193ac33f"),
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
                        .HasForeignKey("FkActivityTypeId");

                    b.HasOne("FlowCRM.Shared.Entities.Deal", "Deals")
                        .WithMany("Activities")
                        .HasForeignKey("FkDealId");

                    b.Navigation("ActivitiesType");

                    b.Navigation("Deals");
                });

            modelBuilder.Entity("FlowCRM.Shared.Entities.Contact", b =>
                {
                    b.HasOne("FlowCRM.Shared.Entities.Company", "Companies")
                        .WithMany("Contacts")
                        .HasForeignKey("FkCompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

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
                        .HasForeignKey("FkCompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FlowCRM.Shared.Entities.Priority", "Priorities")
                        .WithMany("Leads")
                        .HasForeignKey("FkPriorityId")
                        .OnDelete(DeleteBehavior.Cascade);

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
