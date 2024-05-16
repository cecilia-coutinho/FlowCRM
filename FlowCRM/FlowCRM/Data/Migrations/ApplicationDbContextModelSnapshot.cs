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
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("FkDealId")
                        .IsRequired()
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
                            ActivityTypeId = new Guid("56dcf1fa-aa86-443d-8548-d43db5cbb069"),
                            TypeName = "Call"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("87f2315f-211e-4450-80f0-65b41fb88e6a"),
                            TypeName = "Meeting"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("7b00cec1-557d-449a-9790-94c0118331dc"),
                            TypeName = "Email"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("a832adc7-cfb9-4fea-a8ec-0a1a141abddb"),
                            TypeName = "Task"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("b4a85468-f70b-46a5-9e81-f2e9e70d650a"),
                            TypeName = "Note"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("c76d864f-b4b4-42fc-9bf6-b0b919bd8f94"),
                            TypeName = "Other"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("dd8f774e-b72d-4a1a-ac09-b05a561ac31b"),
                            TypeName = "Follow-up"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("8ce89359-7f8a-4dca-a336-9f2ba93f7567"),
                            TypeName = "Demo"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("1a5fefc8-7987-431a-9402-63c2897fbca2"),
                            TypeName = "Presentation"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("a600831f-e623-4edf-b01a-645f5691e1e0"),
                            TypeName = "Training"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("a53294d9-1fdd-4e21-89b4-6bd1c50624a6"),
                            TypeName = "Webinar"
                        },
                        new
                        {
                            ActivityTypeId = new Guid("f8dca3cf-abb9-422a-9f58-70e7251f6a85"),
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
                            CompanyId = new Guid("b555db74-2694-4872-8945-8085f2a0660e"),
                            City = "Redmond",
                            CompanyAddress = "Redmond, Washington",
                            CompanyEmailAddress = "microsoft.example@example.com",
                            CompanyName = "Microsoft",
                            CompanyPhoneNumber = "123456789",
                            Country = "USA",
                            CreatedAt = new DateTime(2024, 5, 16, 14, 14, 27, 30, DateTimeKind.Local).AddTicks(3887)
                        },
                        new
                        {
                            CompanyId = new Guid("1c160cd5-7652-4658-b977-cc94847cb421"),
                            City = "Cupertino",
                            CompanyAddress = "Cupertino, California",
                            CompanyEmailAddress = "apple.example@example.com",
                            CompanyName = "Apple",
                            CompanyPhoneNumber = "123456780",
                            Country = "USA",
                            CreatedAt = new DateTime(2024, 5, 16, 14, 14, 27, 30, DateTimeKind.Local).AddTicks(3912)
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
                            ContactId = new Guid("dcf45826-382c-4b8e-a6be-47061bed1523"),
                            CreatedAt = new DateTime(2024, 5, 16, 14, 14, 27, 30, DateTimeKind.Local).AddTicks(3959),
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
                            CustomerId = new Guid("609e9380-3f77-4da6-b074-eb55731fc586"),
                            City = "New York",
                            Country = "USA",
                            CreatedAt = new DateTime(2024, 5, 16, 14, 14, 27, 30, DateTimeKind.Local).AddTicks(3459),
                            Email = "john.doe@example.com",
                            FirstName = "John",
                            LastName = "Doe",
                            PhoneNumber = "123456789"
                        },
                        new
                        {
                            CustomerId = new Guid("e6fb1c9c-39eb-4c41-b01b-1f0459880487"),
                            City = "California",
                            Country = "USA",
                            CreatedAt = new DateTime(2024, 5, 16, 14, 14, 27, 30, DateTimeKind.Local).AddTicks(3543),
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
                            DealStatusId = new Guid("fd855729-ff2b-41e4-a51d-d4b53fc6d15b"),
                            StatusName = "New"
                        },
                        new
                        {
                            DealStatusId = new Guid("fd1a56ae-4816-4fdf-ac0e-59b03422183c"),
                            StatusName = "In Progress"
                        },
                        new
                        {
                            DealStatusId = new Guid("4a98571b-0aa3-493a-abae-a807b52af92d"),
                            StatusName = "Closed Won"
                        },
                        new
                        {
                            DealStatusId = new Guid("6d156d23-4fb6-4065-8d50-7b0fcb5fc812"),
                            StatusName = "Closed Lost"
                        },
                        new
                        {
                            DealStatusId = new Guid("761c73f2-0b2c-4f46-ae6c-1ea87103a63a"),
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
                            PriorityId = new Guid("34868370-70ed-4465-a42d-f8e2104c47f3"),
                            PriorityName = "Low"
                        },
                        new
                        {
                            PriorityId = new Guid("c920f02f-de76-4788-87f4-d6b2bd7552f3"),
                            PriorityName = "Medium"
                        },
                        new
                        {
                            PriorityId = new Guid("abedb50f-a889-4c43-bd86-bd744833d112"),
                            PriorityName = "High"
                        },
                        new
                        {
                            PriorityId = new Guid("8c7397e6-e683-4e5c-9b3e-8df4f3945e3a"),
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
