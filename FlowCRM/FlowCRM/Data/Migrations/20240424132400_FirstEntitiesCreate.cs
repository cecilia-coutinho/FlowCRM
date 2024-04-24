using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FlowCRM.Migrations
{
    /// <inheritdoc />
    public partial class FirstEntitiesCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activity_ActivityType_ActivitiesTypeActivityTypeId",
                table: "Activity");

            migrationBuilder.DropForeignKey(
                name: "FK_Activity_Deal_DealsDealId",
                table: "Activity");

            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Company_CompaniesCompanyId",
                table: "Contact");

            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Customers_CustomersCustomerId",
                table: "Contact");

            migrationBuilder.DropForeignKey(
                name: "FK_Deal_Company_CompaniesCompanyId",
                table: "Deal");

            migrationBuilder.DropForeignKey(
                name: "FK_Deal_Customers_CustomersCustomerId",
                table: "Deal");

            migrationBuilder.DropForeignKey(
                name: "FK_Deal_DealStatus_DealsStatusDealStatusId",
                table: "Deal");

            migrationBuilder.DropForeignKey(
                name: "FK_Deal_Priority_PrioritiesPriorityId",
                table: "Deal");

            migrationBuilder.DropForeignKey(
                name: "FK_Lead_Company_CompaniesCompanyId",
                table: "Lead");

            migrationBuilder.DropForeignKey(
                name: "FK_Lead_Priority_PrioritiesPriorityId",
                table: "Lead");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Priority",
                table: "Priority");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lead",
                table: "Lead");

            migrationBuilder.DropIndex(
                name: "IX_Lead_CompaniesCompanyId",
                table: "Lead");

            migrationBuilder.DropIndex(
                name: "IX_Lead_PrioritiesPriorityId",
                table: "Lead");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DealStatus",
                table: "DealStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Deal",
                table: "Deal");

            migrationBuilder.DropIndex(
                name: "IX_Deal_CompaniesCompanyId",
                table: "Deal");

            migrationBuilder.DropIndex(
                name: "IX_Deal_CustomersCustomerId",
                table: "Deal");

            migrationBuilder.DropIndex(
                name: "IX_Deal_DealsStatusDealStatusId",
                table: "Deal");

            migrationBuilder.DropIndex(
                name: "IX_Deal_PrioritiesPriorityId",
                table: "Deal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contact",
                table: "Contact");

            migrationBuilder.DropIndex(
                name: "IX_Contact_CompaniesCompanyId",
                table: "Contact");

            migrationBuilder.DropIndex(
                name: "IX_Contact_CustomersCustomerId",
                table: "Contact");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Company",
                table: "Company");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ActivityType",
                table: "ActivityType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Activity",
                table: "Activity");

            migrationBuilder.DropIndex(
                name: "IX_Activity_ActivitiesTypeActivityTypeId",
                table: "Activity");

            migrationBuilder.DropIndex(
                name: "IX_Activity_DealsDealId",
                table: "Activity");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("7d0049d5-1171-4ff9-9881-e443b28ce5b8"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("ba4a7f51-21e0-4bfb-aa93-710c5c41af10"));

            migrationBuilder.DropColumn(
                name: "CompaniesCompanyId",
                table: "Lead");

            migrationBuilder.DropColumn(
                name: "PrioritiesPriorityId",
                table: "Lead");

            migrationBuilder.DropColumn(
                name: "CompaniesCompanyId",
                table: "Deal");

            migrationBuilder.DropColumn(
                name: "CustomersCustomerId",
                table: "Deal");

            migrationBuilder.DropColumn(
                name: "DealsStatusDealStatusId",
                table: "Deal");

            migrationBuilder.DropColumn(
                name: "PrioritiesPriorityId",
                table: "Deal");

            migrationBuilder.DropColumn(
                name: "CompaniesCompanyId",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "CustomersCustomerId",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "ActivitiesTypeActivityTypeId",
                table: "Activity");

            migrationBuilder.DropColumn(
                name: "DealsDealId",
                table: "Activity");

            migrationBuilder.RenameTable(
                name: "Priority",
                newName: "Priorities");

            migrationBuilder.RenameTable(
                name: "Lead",
                newName: "Leads");

            migrationBuilder.RenameTable(
                name: "DealStatus",
                newName: "DealsStatus");

            migrationBuilder.RenameTable(
                name: "Deal",
                newName: "Deals");

            migrationBuilder.RenameTable(
                name: "Contact",
                newName: "Contacts");

            migrationBuilder.RenameTable(
                name: "Company",
                newName: "Companies");

            migrationBuilder.RenameTable(
                name: "ActivityType",
                newName: "ActivitiesType");

            migrationBuilder.RenameTable(
                name: "Activity",
                newName: "Activities");

            migrationBuilder.AlterColumn<string>(
                name: "PriorityName",
                table: "Priorities",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "StatusName",
                table: "DealsStatus",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Contacts",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "Companies",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyEmailAddress",
                table: "Companies",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TypeName",
                table: "ActivitiesType",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Priorities",
                table: "Priorities",
                column: "PriorityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Leads",
                table: "Leads",
                column: "LeadId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DealsStatus",
                table: "DealsStatus",
                column: "DealStatusId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Deals",
                table: "Deals",
                column: "DealId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts",
                column: "ContactId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Companies",
                table: "Companies",
                column: "CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ActivitiesType",
                table: "ActivitiesType",
                column: "ActivityTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Activities",
                table: "Activities",
                column: "ActivityId");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "City", "Country", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "PhoneNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0c632803-e079-417d-a67d-c809ef3a8b8c"), "California", "USA", new DateTime(2024, 4, 24, 15, 23, 58, 981, DateTimeKind.Local).AddTicks(5670), null, "maria.rosa@example.com", "Maria", "Rosa", "123456780", null, null },
                    { new Guid("9530287f-5ab3-4692-b861-c1db40a30196"), "New York", "USA", new DateTime(2024, 4, 24, 15, 23, 58, 981, DateTimeKind.Local).AddTicks(5601), null, "john.doe@example.com", "John", "Doe", "123456789", null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Priorities_PriorityName",
                table: "Priorities",
                column: "PriorityName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Leads_FkCompanyId",
                table: "Leads",
                column: "FkCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Leads_FkPriorityId",
                table: "Leads",
                column: "FkPriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_DealsStatus_StatusName",
                table: "DealsStatus",
                column: "StatusName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Deals_FkCompanyId",
                table: "Deals",
                column: "FkCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Deals_FkCustomerId",
                table: "Deals",
                column: "FkCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Deals_FkDealStatusId",
                table: "Deals",
                column: "FkDealStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Deals_FkPriorityId",
                table: "Deals",
                column: "FkPriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_Email",
                table: "Contacts",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_FkCompanyId",
                table: "Contacts",
                column: "FkCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_FkCustomerId",
                table: "Contacts",
                column: "FkCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CompanyEmailAddress",
                table: "Companies",
                column: "CompanyEmailAddress",
                unique: true,
                filter: "[CompanyEmailAddress] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CompanyName",
                table: "Companies",
                column: "CompanyName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ActivitiesType_TypeName",
                table: "ActivitiesType",
                column: "TypeName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Activities_FkActivityTypeId",
                table: "Activities",
                column: "FkActivityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_FkDealId",
                table: "Activities",
                column: "FkDealId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_ActivitiesType_FkActivityTypeId",
                table: "Activities",
                column: "FkActivityTypeId",
                principalTable: "ActivitiesType",
                principalColumn: "ActivityTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Deals_FkDealId",
                table: "Activities",
                column: "FkDealId",
                principalTable: "Deals",
                principalColumn: "DealId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Companies_FkCompanyId",
                table: "Contacts",
                column: "FkCompanyId",
                principalTable: "Companies",
                principalColumn: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Customers_FkCustomerId",
                table: "Contacts",
                column: "FkCustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Deals_Companies_FkCompanyId",
                table: "Deals",
                column: "FkCompanyId",
                principalTable: "Companies",
                principalColumn: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Deals_Customers_FkCustomerId",
                table: "Deals",
                column: "FkCustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Deals_DealsStatus_FkDealStatusId",
                table: "Deals",
                column: "FkDealStatusId",
                principalTable: "DealsStatus",
                principalColumn: "DealStatusId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Deals_Priorities_FkPriorityId",
                table: "Deals",
                column: "FkPriorityId",
                principalTable: "Priorities",
                principalColumn: "PriorityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Leads_Companies_FkCompanyId",
                table: "Leads",
                column: "FkCompanyId",
                principalTable: "Companies",
                principalColumn: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Leads_Priorities_FkPriorityId",
                table: "Leads",
                column: "FkPriorityId",
                principalTable: "Priorities",
                principalColumn: "PriorityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_ActivitiesType_FkActivityTypeId",
                table: "Activities");

            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Deals_FkDealId",
                table: "Activities");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Companies_FkCompanyId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Customers_FkCustomerId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Deals_Companies_FkCompanyId",
                table: "Deals");

            migrationBuilder.DropForeignKey(
                name: "FK_Deals_Customers_FkCustomerId",
                table: "Deals");

            migrationBuilder.DropForeignKey(
                name: "FK_Deals_DealsStatus_FkDealStatusId",
                table: "Deals");

            migrationBuilder.DropForeignKey(
                name: "FK_Deals_Priorities_FkPriorityId",
                table: "Deals");

            migrationBuilder.DropForeignKey(
                name: "FK_Leads_Companies_FkCompanyId",
                table: "Leads");

            migrationBuilder.DropForeignKey(
                name: "FK_Leads_Priorities_FkPriorityId",
                table: "Leads");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Priorities",
                table: "Priorities");

            migrationBuilder.DropIndex(
                name: "IX_Priorities_PriorityName",
                table: "Priorities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Leads",
                table: "Leads");

            migrationBuilder.DropIndex(
                name: "IX_Leads_FkCompanyId",
                table: "Leads");

            migrationBuilder.DropIndex(
                name: "IX_Leads_FkPriorityId",
                table: "Leads");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DealsStatus",
                table: "DealsStatus");

            migrationBuilder.DropIndex(
                name: "IX_DealsStatus_StatusName",
                table: "DealsStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Deals",
                table: "Deals");

            migrationBuilder.DropIndex(
                name: "IX_Deals_FkCompanyId",
                table: "Deals");

            migrationBuilder.DropIndex(
                name: "IX_Deals_FkCustomerId",
                table: "Deals");

            migrationBuilder.DropIndex(
                name: "IX_Deals_FkDealStatusId",
                table: "Deals");

            migrationBuilder.DropIndex(
                name: "IX_Deals_FkPriorityId",
                table: "Deals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_Email",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_FkCompanyId",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_FkCustomerId",
                table: "Contacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Companies",
                table: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Companies_CompanyEmailAddress",
                table: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Companies_CompanyName",
                table: "Companies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ActivitiesType",
                table: "ActivitiesType");

            migrationBuilder.DropIndex(
                name: "IX_ActivitiesType_TypeName",
                table: "ActivitiesType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Activities",
                table: "Activities");

            migrationBuilder.DropIndex(
                name: "IX_Activities_FkActivityTypeId",
                table: "Activities");

            migrationBuilder.DropIndex(
                name: "IX_Activities_FkDealId",
                table: "Activities");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("0c632803-e079-417d-a67d-c809ef3a8b8c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("9530287f-5ab3-4692-b861-c1db40a30196"));

            migrationBuilder.RenameTable(
                name: "Priorities",
                newName: "Priority");

            migrationBuilder.RenameTable(
                name: "Leads",
                newName: "Lead");

            migrationBuilder.RenameTable(
                name: "DealsStatus",
                newName: "DealStatus");

            migrationBuilder.RenameTable(
                name: "Deals",
                newName: "Deal");

            migrationBuilder.RenameTable(
                name: "Contacts",
                newName: "Contact");

            migrationBuilder.RenameTable(
                name: "Companies",
                newName: "Company");

            migrationBuilder.RenameTable(
                name: "ActivitiesType",
                newName: "ActivityType");

            migrationBuilder.RenameTable(
                name: "Activities",
                newName: "Activity");

            migrationBuilder.AlterColumn<string>(
                name: "PriorityName",
                table: "Priority",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<Guid>(
                name: "CompaniesCompanyId",
                table: "Lead",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PrioritiesPriorityId",
                table: "Lead",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StatusName",
                table: "DealStatus",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<Guid>(
                name: "CompaniesCompanyId",
                table: "Deal",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CustomersCustomerId",
                table: "Deal",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DealsStatusDealStatusId",
                table: "Deal",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PrioritiesPriorityId",
                table: "Deal",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<Guid>(
                name: "CompaniesCompanyId",
                table: "Contact",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CustomersCustomerId",
                table: "Contact",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "Company",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyEmailAddress",
                table: "Company",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TypeName",
                table: "ActivityType",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<Guid>(
                name: "ActivitiesTypeActivityTypeId",
                table: "Activity",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DealsDealId",
                table: "Activity",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Priority",
                table: "Priority",
                column: "PriorityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lead",
                table: "Lead",
                column: "LeadId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DealStatus",
                table: "DealStatus",
                column: "DealStatusId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Deal",
                table: "Deal",
                column: "DealId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contact",
                table: "Contact",
                column: "ContactId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Company",
                table: "Company",
                column: "CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ActivityType",
                table: "ActivityType",
                column: "ActivityTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Activity",
                table: "Activity",
                column: "ActivityId");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "City", "Country", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "PhoneNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("7d0049d5-1171-4ff9-9881-e443b28ce5b8"), "New York", "USA", new DateTime(2024, 4, 23, 18, 40, 45, 728, DateTimeKind.Local).AddTicks(9401), null, "john.doe@example.com", "John", "Doe", "123456789", null, null },
                    { new Guid("ba4a7f51-21e0-4bfb-aa93-710c5c41af10"), "California", "USA", new DateTime(2024, 4, 23, 18, 40, 45, 728, DateTimeKind.Local).AddTicks(9452), null, "maria.rosa@example.com", "Maria", "Rosa", "123456780", null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lead_CompaniesCompanyId",
                table: "Lead",
                column: "CompaniesCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Lead_PrioritiesPriorityId",
                table: "Lead",
                column: "PrioritiesPriorityId");

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
                name: "IX_Contact_CompaniesCompanyId",
                table: "Contact",
                column: "CompaniesCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_CustomersCustomerId",
                table: "Contact",
                column: "CustomersCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Activity_ActivitiesTypeActivityTypeId",
                table: "Activity",
                column: "ActivitiesTypeActivityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Activity_DealsDealId",
                table: "Activity",
                column: "DealsDealId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_ActivityType_ActivitiesTypeActivityTypeId",
                table: "Activity",
                column: "ActivitiesTypeActivityTypeId",
                principalTable: "ActivityType",
                principalColumn: "ActivityTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_Deal_DealsDealId",
                table: "Activity",
                column: "DealsDealId",
                principalTable: "Deal",
                principalColumn: "DealId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Company_CompaniesCompanyId",
                table: "Contact",
                column: "CompaniesCompanyId",
                principalTable: "Company",
                principalColumn: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Customers_CustomersCustomerId",
                table: "Contact",
                column: "CustomersCustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Deal_Company_CompaniesCompanyId",
                table: "Deal",
                column: "CompaniesCompanyId",
                principalTable: "Company",
                principalColumn: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Deal_Customers_CustomersCustomerId",
                table: "Deal",
                column: "CustomersCustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Deal_DealStatus_DealsStatusDealStatusId",
                table: "Deal",
                column: "DealsStatusDealStatusId",
                principalTable: "DealStatus",
                principalColumn: "DealStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Deal_Priority_PrioritiesPriorityId",
                table: "Deal",
                column: "PrioritiesPriorityId",
                principalTable: "Priority",
                principalColumn: "PriorityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lead_Company_CompaniesCompanyId",
                table: "Lead",
                column: "CompaniesCompanyId",
                principalTable: "Company",
                principalColumn: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lead_Priority_PrioritiesPriorityId",
                table: "Lead",
                column: "PrioritiesPriorityId",
                principalTable: "Priority",
                principalColumn: "PriorityId");
        }
    }
}
