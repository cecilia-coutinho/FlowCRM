using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FlowCRM.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("56724198-b146-4653-a9cd-55646e2e85d4"));

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Customers",
                newName: "PhoneNumber");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customers",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Customers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "Customers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Customers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedBy",
                table: "Customers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ActivityType",
                columns: table => new
                {
                    ActivityTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityType", x => x.ActivityTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyEmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "DealStatus",
                columns: table => new
                {
                    DealStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StatusName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DealStatus", x => x.DealStatusId);
                });

            migrationBuilder.CreateTable(
                name: "Priority",
                columns: table => new
                {
                    PriorityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PriorityName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Priority", x => x.PriorityId);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    ContactId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FkCustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FkCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CustomersCustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CompaniesCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.ContactId);
                    table.ForeignKey(
                        name: "FK_Contact_Company_CompaniesCompanyId",
                        column: x => x.CompaniesCompanyId,
                        principalTable: "Company",
                        principalColumn: "CompanyId");
                    table.ForeignKey(
                        name: "FK_Contact_Customers_CustomersCustomerId",
                        column: x => x.CustomersCustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId");
                });

            migrationBuilder.CreateTable(
                name: "Deal",
                columns: table => new
                {
                    DealId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FkCustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FkCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DealAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FkDealStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FkPriorityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CustomersCustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CompaniesCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DealsStatusDealStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PrioritiesPriorityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deal", x => x.DealId);
                    table.ForeignKey(
                        name: "FK_Deal_Company_CompaniesCompanyId",
                        column: x => x.CompaniesCompanyId,
                        principalTable: "Company",
                        principalColumn: "CompanyId");
                    table.ForeignKey(
                        name: "FK_Deal_Customers_CustomersCustomerId",
                        column: x => x.CustomersCustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId");
                    table.ForeignKey(
                        name: "FK_Deal_DealStatus_DealsStatusDealStatusId",
                        column: x => x.DealsStatusDealStatusId,
                        principalTable: "DealStatus",
                        principalColumn: "DealStatusId");
                    table.ForeignKey(
                        name: "FK_Deal_Priority_PrioritiesPriorityId",
                        column: x => x.PrioritiesPriorityId,
                        principalTable: "Priority",
                        principalColumn: "PriorityId");
                });

            migrationBuilder.CreateTable(
                name: "Lead",
                columns: table => new
                {
                    LeadId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FkPriorityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FkCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PrioritiesPriorityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CompaniesCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lead", x => x.LeadId);
                    table.ForeignKey(
                        name: "FK_Lead_Company_CompaniesCompanyId",
                        column: x => x.CompaniesCompanyId,
                        principalTable: "Company",
                        principalColumn: "CompanyId");
                    table.ForeignKey(
                        name: "FK_Lead_Priority_PrioritiesPriorityId",
                        column: x => x.PrioritiesPriorityId,
                        principalTable: "Priority",
                        principalColumn: "PriorityId");
                });

            migrationBuilder.CreateTable(
                name: "Activity",
                columns: table => new
                {
                    ActivityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FkDealId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FkActivityTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActivityNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActivityDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DealsDealId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ActivitiesTypeActivityTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activity", x => x.ActivityId);
                    table.ForeignKey(
                        name: "FK_Activity_ActivityType_ActivitiesTypeActivityTypeId",
                        column: x => x.ActivitiesTypeActivityTypeId,
                        principalTable: "ActivityType",
                        principalColumn: "ActivityTypeId");
                    table.ForeignKey(
                        name: "FK_Activity_Deal_DealsDealId",
                        column: x => x.DealsDealId,
                        principalTable: "Deal",
                        principalColumn: "DealId");
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "City", "Country", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "PhoneNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("7d0049d5-1171-4ff9-9881-e443b28ce5b8"), "New York", "USA", new DateTime(2024, 4, 23, 18, 40, 45, 728, DateTimeKind.Local).AddTicks(9401), null, "john.doe@example.com", "John", "Doe", "123456789", null, null },
                    { new Guid("ba4a7f51-21e0-4bfb-aa93-710c5c41af10"), "California", "USA", new DateTime(2024, 4, 23, 18, 40, 45, 728, DateTimeKind.Local).AddTicks(9452), null, "maria.rosa@example.com", "Maria", "Rosa", "123456780", null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Email",
                table: "Customers",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Activity_ActivitiesTypeActivityTypeId",
                table: "Activity",
                column: "ActivitiesTypeActivityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Activity_DealsDealId",
                table: "Activity",
                column: "DealsDealId");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_CompaniesCompanyId",
                table: "Contact",
                column: "CompaniesCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_CustomersCustomerId",
                table: "Contact",
                column: "CustomersCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Deal_CompaniesCompanyId",
                table: "Deal",
                column: "CompaniesCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Deal_CustomersCustomerId",
                table: "Deal",
                column: "CustomersCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Deal_DealsStatusDealStatusId",
                table: "Deal",
                column: "DealsStatusDealStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Deal_PrioritiesPriorityId",
                table: "Deal",
                column: "PrioritiesPriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_Lead_CompaniesCompanyId",
                table: "Lead",
                column: "CompaniesCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Lead_PrioritiesPriorityId",
                table: "Lead",
                column: "PrioritiesPriorityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activity");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Lead");

            migrationBuilder.DropTable(
                name: "ActivityType");

            migrationBuilder.DropTable(
                name: "Deal");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "DealStatus");

            migrationBuilder.DropTable(
                name: "Priority");

            migrationBuilder.DropIndex(
                name: "IX_Customers_Email",
                table: "Customers");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("7d0049d5-1171-4ff9-9881-e443b28ce5b8"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("ba4a7f51-21e0-4bfb-aa93-710c5c41af10"));

            migrationBuilder.DropColumn(
                name: "City",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Customers",
                newName: "Phone");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Email", "FirstName", "LastName", "Phone" },
                values: new object[] { new Guid("56724198-b146-4653-a9cd-55646e2e85d4"), "john.doe@example.com", "John", "Doe", null });
        }
    }
}
