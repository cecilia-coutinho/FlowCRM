using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FlowCRM.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("053709a9-73b8-42fd-bd1e-6782e1a67d55"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("209e87dc-d5fb-4b2d-b642-e94da30411b7"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: new Guid("ea79b95a-7f0b-44a5-b6bb-279f3750faaf"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("0f362275-9ad5-460d-a931-1eb25726939f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("836d8bca-c975-4425-bea5-39ec059012bf"));

            migrationBuilder.InsertData(
                table: "ActivitiesType",
                columns: new[] { "ActivityTypeId", "TypeName" },
                values: new object[,]
                {
                    { new Guid("038fcd9e-79a1-4720-9bec-d2bd8cdba0d8"), "Training" },
                    { new Guid("0c25d441-3602-4e43-b6ff-ecd513e1b308"), "Webinar" },
                    { new Guid("10275ae0-4c95-47bd-9fbe-a402bcb3a883"), "Workshop" },
                    { new Guid("32c0fa65-169b-4f21-b147-77e2b641311d"), "Presentation" },
                    { new Guid("5a55fb70-5698-4d95-8b1f-f600b3ff6107"), "Note" },
                    { new Guid("5b65182d-c62c-41bf-961c-af3e44e779d2"), "Call" },
                    { new Guid("6f03e807-1aef-41a3-9d31-929c9df658c6"), "Email" },
                    { new Guid("943fe237-8bc5-4ccc-8aee-cdf47f2cbbac"), "Meeting" },
                    { new Guid("9ff39f91-d2d2-4f89-be98-8023b7c85d01"), "Other" },
                    { new Guid("c948bd90-e3eb-46b9-a97e-bc539f9cb14c"), "Demo" },
                    { new Guid("d3d9d09b-cabb-4e8d-bcf8-8bbf9e183dc6"), "Task" },
                    { new Guid("d8e92620-1647-4af8-a89a-7588efd8f9f0"), "Follow-up" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "City", "CompanyAddress", "CompanyEmailAddress", "CompanyName", "CompanyPhoneNumber", "Country", "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("1774118b-289c-451d-a202-3f8a80ba07f4"), "Redmond", "Redmond, Washington", "microsoft.example@example.com", "Microsoft", "123456789", "USA", new DateTime(2024, 4, 25, 17, 46, 10, 862, DateTimeKind.Local).AddTicks(4018), null, null, null },
                    { new Guid("bc0050f8-a7fa-4f7d-b431-f9a6c1eb5017"), "Cupertino", "Cupertino, California", "apple.example@example.com", "Apple", "123456780", "USA", new DateTime(2024, 4, 25, 17, 46, 10, 862, DateTimeKind.Local).AddTicks(4022), null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "CreatedAt", "CreatedBy", "Email", "FirstName", "FkCompanyId", "FkCustomerId", "LastName", "PhoneNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("d2881f72-9888-4179-9c57-75a93d33566a"), new DateTime(2024, 4, 25, 17, 46, 10, 862, DateTimeKind.Local).AddTicks(4045), null, "anna.banana@example.com", "Anna", null, null, "Banana", "123456789", null, null });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "City", "Country", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "PhoneNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("97b59b37-f243-42be-8310-a77af427517f"), "California", "USA", new DateTime(2024, 4, 25, 17, 46, 10, 862, DateTimeKind.Local).AddTicks(3862), null, "maria.rosa@example.com", "Maria", "Rosa", "123456780", null, null },
                    { new Guid("eb3c7d07-3ba0-46d6-9711-0a77d72587c7"), "New York", "USA", new DateTime(2024, 4, 25, 17, 46, 10, 862, DateTimeKind.Local).AddTicks(3771), null, "john.doe@example.com", "John", "Doe", "123456789", null, null }
                });

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "PriorityId", "PriorityName" },
                values: new object[,]
                {
                    { new Guid("0e04c361-8422-439b-aa6a-edcfd0097b08"), "Low" },
                    { new Guid("6850bf64-9483-4de2-8728-d292696ce0d5"), "High" },
                    { new Guid("686b928d-2584-4a97-87fc-d8ef4c2c6141"), "Urgent" },
                    { new Guid("80ccde9c-7998-4138-891a-a79e8384d166"), "Medium" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("038fcd9e-79a1-4720-9bec-d2bd8cdba0d8"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("0c25d441-3602-4e43-b6ff-ecd513e1b308"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("10275ae0-4c95-47bd-9fbe-a402bcb3a883"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("32c0fa65-169b-4f21-b147-77e2b641311d"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("5a55fb70-5698-4d95-8b1f-f600b3ff6107"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("5b65182d-c62c-41bf-961c-af3e44e779d2"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("6f03e807-1aef-41a3-9d31-929c9df658c6"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("943fe237-8bc5-4ccc-8aee-cdf47f2cbbac"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("9ff39f91-d2d2-4f89-be98-8023b7c85d01"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("c948bd90-e3eb-46b9-a97e-bc539f9cb14c"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("d3d9d09b-cabb-4e8d-bcf8-8bbf9e183dc6"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("d8e92620-1647-4af8-a89a-7588efd8f9f0"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("1774118b-289c-451d-a202-3f8a80ba07f4"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("bc0050f8-a7fa-4f7d-b431-f9a6c1eb5017"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: new Guid("d2881f72-9888-4179-9c57-75a93d33566a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("97b59b37-f243-42be-8310-a77af427517f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("eb3c7d07-3ba0-46d6-9711-0a77d72587c7"));

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: new Guid("0e04c361-8422-439b-aa6a-edcfd0097b08"));

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: new Guid("6850bf64-9483-4de2-8728-d292696ce0d5"));

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: new Guid("686b928d-2584-4a97-87fc-d8ef4c2c6141"));

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: new Guid("80ccde9c-7998-4138-891a-a79e8384d166"));

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "City", "CompanyAddress", "CompanyEmailAddress", "CompanyName", "CompanyPhoneNumber", "Country", "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("053709a9-73b8-42fd-bd1e-6782e1a67d55"), "Cupertino", "Cupertino, California", "apple.example@example.com", "Apple", "123456780", "USA", new DateTime(2024, 4, 25, 14, 37, 1, 509, DateTimeKind.Local).AddTicks(6049), null, null, null },
                    { new Guid("209e87dc-d5fb-4b2d-b642-e94da30411b7"), "Redmond", "Redmond, Washington", "microsoft.example@example.com", "Microsoft", "123456789", "USA", new DateTime(2024, 4, 25, 14, 37, 1, 509, DateTimeKind.Local).AddTicks(6046), null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "CreatedAt", "CreatedBy", "Email", "FirstName", "FkCompanyId", "FkCustomerId", "LastName", "PhoneNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("ea79b95a-7f0b-44a5-b6bb-279f3750faaf"), new DateTime(2024, 4, 25, 14, 37, 1, 509, DateTimeKind.Local).AddTicks(6074), null, "anna.banana@example.com", "Anna", null, null, "Banana", "123456789", null, null });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "City", "Country", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "PhoneNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0f362275-9ad5-460d-a931-1eb25726939f"), "California", "USA", new DateTime(2024, 4, 25, 14, 37, 1, 509, DateTimeKind.Local).AddTicks(5950), null, "maria.rosa@example.com", "Maria", "Rosa", "123456780", null, null },
                    { new Guid("836d8bca-c975-4425-bea5-39ec059012bf"), "New York", "USA", new DateTime(2024, 4, 25, 14, 37, 1, 509, DateTimeKind.Local).AddTicks(5898), null, "john.doe@example.com", "John", "Doe", "123456789", null, null }
                });
        }
    }
}
