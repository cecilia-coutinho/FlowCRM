using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FlowCRM.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMigrations2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("1242e62f-e4fc-4275-ba1b-3f34ef553451"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("1cf0ceb5-f597-4057-8af4-95a7fe210a16"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("20128b82-bd6f-4742-b5af-99696a228e7a"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("6906efe6-b468-463b-9cad-efb74559bb1f"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("7feb3899-361d-4eaf-9b95-18a40424085b"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("8932a361-47e2-4599-8e2b-50ac4f56cda4"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("a362012e-a7eb-4525-9aac-c97b93b8d0cc"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("a696752c-4a0f-42bd-bf43-cee077d4b8ba"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("e6553456-b9e8-437d-a1fa-87ddf85ac853"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("ed10170d-d290-4620-88d5-85371a43f5c8"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("f56dbb2c-3742-46f2-a492-44862d5199c7"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("f8aa2781-faa9-4fce-b0d0-3c8caa226a1d"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("0943ada5-4642-4a3b-9c16-6da85331612d"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("f04e4ee6-14f5-4cef-8bfc-4e358ffdec1f"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: new Guid("70e4bfc5-22aa-4f7d-bc5e-19f5a9d98bc8"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("3e1d26e8-8db0-484b-9f00-5190354a82ca"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("c68f4adf-e9c0-4720-9f96-b63802343193"));

            migrationBuilder.DeleteData(
                table: "DealsStatus",
                keyColumn: "DealStatusId",
                keyValue: new Guid("10b72225-9421-4643-a7da-ec0c2ff49d2e"));

            migrationBuilder.DeleteData(
                table: "DealsStatus",
                keyColumn: "DealStatusId",
                keyValue: new Guid("23f19d89-a8ee-4d24-8564-0e8db28e2399"));

            migrationBuilder.DeleteData(
                table: "DealsStatus",
                keyColumn: "DealStatusId",
                keyValue: new Guid("5ce4a5b3-a7da-4e62-b678-1a6d1bd84e53"));

            migrationBuilder.DeleteData(
                table: "DealsStatus",
                keyColumn: "DealStatusId",
                keyValue: new Guid("cd53b260-5a5e-4c0f-93d5-741d0e05d41e"));

            migrationBuilder.DeleteData(
                table: "DealsStatus",
                keyColumn: "DealStatusId",
                keyValue: new Guid("ea552b33-0b76-4320-951b-f8103fa22d9d"));

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: new Guid("57543f18-6fad-4719-87ec-7b8b934dd73d"));

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: new Guid("a0fb13a2-4f7b-46da-b730-ae53236ad85e"));

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: new Guid("e648947d-5baa-4e6a-a227-4faa94ae92ee"));

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: new Guid("e92d74c1-43c5-4ada-a5db-9cf06ea6a639"));

            migrationBuilder.InsertData(
                table: "ActivitiesType",
                columns: new[] { "ActivityTypeId", "TypeName" },
                values: new object[,]
                {
                    { new Guid("1368acb1-4760-4d5f-ae72-caee6a83058f"), "Email" },
                    { new Guid("3199fb58-1f23-43ca-a0b3-3f8df971cc6d"), "Task" },
                    { new Guid("485da7c6-1abf-4e49-937b-8a282d36b9ee"), "Follow-up" },
                    { new Guid("52b698e2-d101-4f46-86a6-e6430d25c30b"), "Presentation" },
                    { new Guid("715c2d60-074f-4521-817b-818f34d69a5a"), "Webinar" },
                    { new Guid("72f1dcea-bdfe-4703-82a3-4719a14f808a"), "Demo" },
                    { new Guid("ab56f670-4c2f-4558-9238-9ab03d7e8604"), "Meeting" },
                    { new Guid("b2089b27-bb6d-429e-8d64-f6134bbf8ba2"), "Call" },
                    { new Guid("c77522c8-614f-434b-9ab5-3b5b251a4343"), "Workshop" },
                    { new Guid("db9513f2-2a8e-4d9f-b779-04addc9c33fc"), "Note" },
                    { new Guid("e72e15da-f6af-4629-bb52-4ecf4acbb397"), "Other" },
                    { new Guid("f270ea37-72a4-4acd-a93d-c5556e62c29b"), "Training" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "City", "CompanyAddress", "CompanyEmailAddress", "CompanyName", "CompanyPhoneNumber", "Country", "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("ceae960f-e3af-42c2-8b6f-b9d188b56d2c"), "Redmond", "Redmond, Washington", "microsoft.example@example.com", "Microsoft", "123456789", "USA", new DateTime(2024, 5, 13, 19, 56, 29, 764, DateTimeKind.Local).AddTicks(1953), null, null, null },
                    { new Guid("feb763b0-1ee1-40d9-8a1a-bd6c10367cb5"), "Cupertino", "Cupertino, California", "apple.example@example.com", "Apple", "123456780", "USA", new DateTime(2024, 5, 13, 19, 56, 29, 764, DateTimeKind.Local).AddTicks(1962), null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "CreatedAt", "CreatedBy", "Email", "FirstName", "FkCompanyId", "FkCustomerId", "LastName", "PhoneNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("2205d063-714b-4b74-acb0-ffbc70c92d18"), new DateTime(2024, 5, 13, 19, 56, 29, 764, DateTimeKind.Local).AddTicks(1989), null, "anna.banana@example.com", "Anna", null, null, "Banana", "123456789", null, null });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "City", "Country", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "PhoneNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0132c350-2b07-47cf-a44b-528483a7967c"), "California", "USA", new DateTime(2024, 5, 13, 19, 56, 29, 764, DateTimeKind.Local).AddTicks(1773), null, "maria.rosa@example.com", "Maria", "Rosa", "123456780", null, null },
                    { new Guid("fa59e1b2-774c-409d-bd7a-04956c109d9f"), "New York", "USA", new DateTime(2024, 5, 13, 19, 56, 29, 764, DateTimeKind.Local).AddTicks(1704), null, "john.doe@example.com", "John", "Doe", "123456789", null, null }
                });

            migrationBuilder.InsertData(
                table: "DealsStatus",
                columns: new[] { "DealStatusId", "StatusName" },
                values: new object[,]
                {
                    { new Guid("3932c47a-8a99-488b-82cd-e7465b265443"), "In Progress" },
                    { new Guid("4713d4f4-2bbe-4e1e-9aad-d16b2d4604a9"), "On Hold" },
                    { new Guid("6361abc0-9052-4046-853d-7ddbcdfe0081"), "Closed Won" },
                    { new Guid("9f8b0a66-40a6-4ae3-b08b-c2fd662e661d"), "Closed Lost" },
                    { new Guid("bb7bf642-e8b0-4a04-8dc4-c552630ca5c2"), "New" }
                });

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "PriorityId", "PriorityName" },
                values: new object[,]
                {
                    { new Guid("95a7e7c5-8f5a-4e42-bb7a-1aea75582617"), "Urgent" },
                    { new Guid("c2ed22bf-8f38-4ca2-be60-d0173d37fc6c"), "High" },
                    { new Guid("cfe9631a-56e3-40bc-9b8b-8ad135f2348e"), "Medium" },
                    { new Guid("f7676e72-ab1f-4ff2-98ec-b1c471695a94"), "Low" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("1368acb1-4760-4d5f-ae72-caee6a83058f"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("3199fb58-1f23-43ca-a0b3-3f8df971cc6d"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("485da7c6-1abf-4e49-937b-8a282d36b9ee"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("52b698e2-d101-4f46-86a6-e6430d25c30b"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("715c2d60-074f-4521-817b-818f34d69a5a"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("72f1dcea-bdfe-4703-82a3-4719a14f808a"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("ab56f670-4c2f-4558-9238-9ab03d7e8604"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("b2089b27-bb6d-429e-8d64-f6134bbf8ba2"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("c77522c8-614f-434b-9ab5-3b5b251a4343"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("db9513f2-2a8e-4d9f-b779-04addc9c33fc"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("e72e15da-f6af-4629-bb52-4ecf4acbb397"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("f270ea37-72a4-4acd-a93d-c5556e62c29b"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("ceae960f-e3af-42c2-8b6f-b9d188b56d2c"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("feb763b0-1ee1-40d9-8a1a-bd6c10367cb5"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: new Guid("2205d063-714b-4b74-acb0-ffbc70c92d18"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("0132c350-2b07-47cf-a44b-528483a7967c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("fa59e1b2-774c-409d-bd7a-04956c109d9f"));

            migrationBuilder.DeleteData(
                table: "DealsStatus",
                keyColumn: "DealStatusId",
                keyValue: new Guid("3932c47a-8a99-488b-82cd-e7465b265443"));

            migrationBuilder.DeleteData(
                table: "DealsStatus",
                keyColumn: "DealStatusId",
                keyValue: new Guid("4713d4f4-2bbe-4e1e-9aad-d16b2d4604a9"));

            migrationBuilder.DeleteData(
                table: "DealsStatus",
                keyColumn: "DealStatusId",
                keyValue: new Guid("6361abc0-9052-4046-853d-7ddbcdfe0081"));

            migrationBuilder.DeleteData(
                table: "DealsStatus",
                keyColumn: "DealStatusId",
                keyValue: new Guid("9f8b0a66-40a6-4ae3-b08b-c2fd662e661d"));

            migrationBuilder.DeleteData(
                table: "DealsStatus",
                keyColumn: "DealStatusId",
                keyValue: new Guid("bb7bf642-e8b0-4a04-8dc4-c552630ca5c2"));

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: new Guid("95a7e7c5-8f5a-4e42-bb7a-1aea75582617"));

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: new Guid("c2ed22bf-8f38-4ca2-be60-d0173d37fc6c"));

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: new Guid("cfe9631a-56e3-40bc-9b8b-8ad135f2348e"));

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: new Guid("f7676e72-ab1f-4ff2-98ec-b1c471695a94"));

            migrationBuilder.InsertData(
                table: "ActivitiesType",
                columns: new[] { "ActivityTypeId", "TypeName" },
                values: new object[,]
                {
                    { new Guid("1242e62f-e4fc-4275-ba1b-3f34ef553451"), "Meeting" },
                    { new Guid("1cf0ceb5-f597-4057-8af4-95a7fe210a16"), "Call" },
                    { new Guid("20128b82-bd6f-4742-b5af-99696a228e7a"), "Task" },
                    { new Guid("6906efe6-b468-463b-9cad-efb74559bb1f"), "Workshop" },
                    { new Guid("7feb3899-361d-4eaf-9b95-18a40424085b"), "Email" },
                    { new Guid("8932a361-47e2-4599-8e2b-50ac4f56cda4"), "Presentation" },
                    { new Guid("a362012e-a7eb-4525-9aac-c97b93b8d0cc"), "Other" },
                    { new Guid("a696752c-4a0f-42bd-bf43-cee077d4b8ba"), "Demo" },
                    { new Guid("e6553456-b9e8-437d-a1fa-87ddf85ac853"), "Webinar" },
                    { new Guid("ed10170d-d290-4620-88d5-85371a43f5c8"), "Training" },
                    { new Guid("f56dbb2c-3742-46f2-a492-44862d5199c7"), "Follow-up" },
                    { new Guid("f8aa2781-faa9-4fce-b0d0-3c8caa226a1d"), "Note" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "City", "CompanyAddress", "CompanyEmailAddress", "CompanyName", "CompanyPhoneNumber", "Country", "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0943ada5-4642-4a3b-9c16-6da85331612d"), "Redmond", "Redmond, Washington", "microsoft.example@example.com", "Microsoft", "123456789", "USA", new DateTime(2024, 5, 13, 19, 37, 12, 269, DateTimeKind.Local).AddTicks(2149), null, null, null },
                    { new Guid("f04e4ee6-14f5-4cef-8bfc-4e358ffdec1f"), "Cupertino", "Cupertino, California", "apple.example@example.com", "Apple", "123456780", "USA", new DateTime(2024, 5, 13, 19, 37, 12, 269, DateTimeKind.Local).AddTicks(2158), null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "CreatedAt", "CreatedBy", "Email", "FirstName", "FkCompanyId", "FkCustomerId", "LastName", "PhoneNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("70e4bfc5-22aa-4f7d-bc5e-19f5a9d98bc8"), new DateTime(2024, 5, 13, 19, 37, 12, 269, DateTimeKind.Local).AddTicks(2196), null, "anna.banana@example.com", "Anna", null, null, "Banana", "123456789", null, null });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "City", "Country", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "PhoneNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("3e1d26e8-8db0-484b-9f00-5190354a82ca"), "New York", "USA", new DateTime(2024, 5, 13, 19, 37, 12, 269, DateTimeKind.Local).AddTicks(1814), null, "john.doe@example.com", "John", "Doe", "123456789", null, null },
                    { new Guid("c68f4adf-e9c0-4720-9f96-b63802343193"), "California", "USA", new DateTime(2024, 5, 13, 19, 37, 12, 269, DateTimeKind.Local).AddTicks(1893), null, "maria.rosa@example.com", "Maria", "Rosa", "123456780", null, null }
                });

            migrationBuilder.InsertData(
                table: "DealsStatus",
                columns: new[] { "DealStatusId", "StatusName" },
                values: new object[,]
                {
                    { new Guid("10b72225-9421-4643-a7da-ec0c2ff49d2e"), "On Hold" },
                    { new Guid("23f19d89-a8ee-4d24-8564-0e8db28e2399"), "Closed Won" },
                    { new Guid("5ce4a5b3-a7da-4e62-b678-1a6d1bd84e53"), "In Progress" },
                    { new Guid("cd53b260-5a5e-4c0f-93d5-741d0e05d41e"), "New" },
                    { new Guid("ea552b33-0b76-4320-951b-f8103fa22d9d"), "Closed Lost" }
                });

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "PriorityId", "PriorityName" },
                values: new object[,]
                {
                    { new Guid("57543f18-6fad-4719-87ec-7b8b934dd73d"), "Medium" },
                    { new Guid("a0fb13a2-4f7b-46da-b730-ae53236ad85e"), "Low" },
                    { new Guid("e648947d-5baa-4e6a-a227-4faa94ae92ee"), "Urgent" },
                    { new Guid("e92d74c1-43c5-4ada-a5db-9cf06ea6a639"), "High" }
                });
        }
    }
}
