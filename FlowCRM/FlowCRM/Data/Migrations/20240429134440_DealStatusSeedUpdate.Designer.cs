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
    [Migration("20240429134440_DealStatusSeedUpdate")]
    partial class DealStatusSeedUpdate
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

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("FkActivityTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FkDealId")
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
                            ActivityTypeId = new Guid("33e98c67-4b47-4b32-ab66-507887dc039f"),
                            TypeName = "Call"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("2ceddafc-c6bf-4c6f-816b-a715ddda7a89"),
                            TypeName = "Meeting"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("1e0b3e2b-4230-4bac-b01d-d3c41aa8a098"),
                            TypeName = "Email"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("f8f57284-59d3-4803-8470-71fc4153541a"),
                            TypeName = "Task"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("37c1837a-27b4-471d-9c18-97954eb2a42a"),
                            TypeName = "Note"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("c686a8e7-0140-4a82-9c1e-8820aad011e3"),
                            TypeName = "Other"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("c62a3860-8c2f-480b-9716-80ec6b40864b"),
                            TypeName = "Follow-up"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("3654800c-52b9-4b07-a9cb-630aa3f719c1"),
                            TypeName = "Demo"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("5f478274-ac85-4514-9629-4e30a6062415"),
                            TypeName = "Presentation"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("91ba2708-7e97-4879-b914-a9a6d4544fb7"),
                            TypeName = "Training"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("e0921ac9-f1c1-4e53-bdad-dff4f83ca442"),
                            TypeName = "Webinar"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("10c5c378-58df-4449-8826-c38a49037015"),
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
                            CompanyId = new Guid("e631df5b-70fe-4bdd-bbe2-f382fd44399b"),
                            City = "Redmond",
                            CompanyAddress = "Redmond, Washington",
                            CompanyEmailAddress = "microsoft.example@example.com",
                            CompanyName = "Microsoft",
                            CompanyPhoneNumber = "123456789",
                            Country = "USA",
                            CreatedAt = new DateTime(2024, 4, 29, 15, 44, 40, 193, DateTimeKind.Local).AddTicks(7537)
                        },
                        new
                        {
                            CompanyId = new Guid("a6910354-dee7-4b00-b551-1d577d5d90a3"),
                            City = "Cupertino",
                            CompanyAddress = "Cupertino, California",
                            CompanyEmailAddress = "apple.example@example.com",
                            CompanyName = "Apple",
                            CompanyPhoneNumber = "123456780",
                            Country = "USA",
                            CreatedAt = new DateTime(2024, 4, 29, 15, 44, 40, 193, DateTimeKind.Local).AddTicks(7540)
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
                            ContactId = new Guid("c6eb4cfb-54c6-460c-afe7-22a8c94e48c5"),
                            CreatedAt = new DateTime(2024, 4, 29, 15, 44, 40, 193, DateTimeKind.Local).AddTicks(7557),
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
                            CustomerId = new Guid("7a10bdeb-c80c-4359-aab3-f633c0bd6dea"),
                            City = "New York",
                            Country = "USA",
                            CreatedAt = new DateTime(2024, 4, 29, 15, 44, 40, 193, DateTimeKind.Local).AddTicks(7387),
                            Email = "john.doe@example.com",
                            FirstName = "John",
                            LastName = "Doe",
                            PhoneNumber = "123456789"
                        },
                        new
                        {
                            CustomerId = new Guid("6bdaee29-96c7-421a-9de5-cab6a2961000"),
                            City = "California",
                            Country = "USA",
                            CreatedAt = new DateTime(2024, 4, 29, 15, 44, 40, 193, DateTimeKind.Local).AddTicks(7444),
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
                            DealStatusId = new Guid("57913308-bef9-4a0a-9849-541d9e6c9fca"),
                            StatusName = "New"
                        },
                        new
                        {
                            DealStatusId = new Guid("e2a73c53-0432-4353-82c7-79b5503dfe70"),
                            StatusName = "In Progress"
                        },
                        new
                        {
                            DealStatusId = new Guid("750e4dac-eec3-4f6a-806e-ba037f68a635"),
                            StatusName = "Closed Won"
                        },
                        new
                        {
                            DealStatusId = new Guid("b2cac70d-747b-4d7f-8881-650f3f5c8e2e"),
                            StatusName = "Closed Lost"
                        },
                        new
                        {
                            DealStatusId = new Guid("221d676a-a921-4a0b-ac70-c0fd28d3628f"),
                            StatusName = "On Hold"
                        });
                });

            modelBuilder.Entity("FlowCRM.Shared.Entities.Lead", b =>
                {
                    b.Property<Guid>("LeadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

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
                            PriorityId = new Guid("2dc429d8-5766-45ef-855e-8fa81e8d0803"),
                            PriorityName = "Low"
                        },
                        new
                        {
                            PriorityId = new Guid("d8b9d728-fc51-40b5-9da0-8a21a4566711"),
                            PriorityName = "Medium"
                        },
                        new
                        {
                            PriorityId = new Guid("5268a485-6490-4fb9-8095-8de6bfb9b65d"),
                            PriorityName = "High"
                        },
                        new
                        {
                            PriorityId = new Guid("40b3ab77-6145-4cc9-9c7a-5fbff41f15ee"),
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