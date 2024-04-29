using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FlowCRM.Migrations
{
    /// <inheritdoc />
    public partial class DealStatusSeedUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("0c893744-89f5-4f2d-b645-360905393263"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("10ee2ad7-aae8-4d3b-9eb1-046a0d3a868e"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("217cfa8a-b17e-49d6-853d-3ad31b31ed67"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("23d645a4-ac7d-4848-981a-912dabaa6f9d"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("2efdc879-ba6d-47c0-b0d7-fd76f1211b56"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("3b712953-1d1c-479c-ab3d-06dc18d1b67e"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("642395cb-e8c1-45e3-8803-7991623c999e"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("6ababab1-eb42-4f7c-960f-0a0968a5d87b"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("7919f416-d8fd-4f2a-a301-63a4fc6939d8"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("7df96bf7-fc6d-4ecc-9467-74a7797c5432"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("823ae74e-cbe2-4399-a3ce-5eeb66803d69"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("eb484760-8651-4112-9dc1-1a81cce48ca6"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("84f38628-e598-490e-861b-e41a1b125e13"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("cd4959ef-4c78-4bdd-997c-758e4bc77aac"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: new Guid("49c40adb-34a4-4a2a-af5f-c49a39c85b25"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("2126d2d4-1d82-4c34-8b5b-7ed6c20adc60"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("ca4d16f5-8baa-42da-bdca-5d021a95e9ee"));

            migrationBuilder.DeleteData(
                table: "DealsStatus",
                keyColumn: "DealStatusId",
                keyValue: new Guid("12283029-d4e0-4dbc-8821-e5535d84bc87"));

            migrationBuilder.DeleteData(
                table: "DealsStatus",
                keyColumn: "DealStatusId",
                keyValue: new Guid("1a8ede24-4344-4185-ae6d-546ec12dca15"));

            migrationBuilder.DeleteData(
                table: "DealsStatus",
                keyColumn: "DealStatusId",
                keyValue: new Guid("3185e235-7a2d-4dab-a7ff-2ca4cf93eb24"));

            migrationBuilder.DeleteData(
                table: "DealsStatus",
                keyColumn: "DealStatusId",
                keyValue: new Guid("797bb361-cbec-4f4d-a8d4-33d733eb4dfd"));

            migrationBuilder.DeleteData(
                table: "DealsStatus",
                keyColumn: "DealStatusId",
                keyValue: new Guid("ed766399-4edb-4dc7-a63d-d7bdd05c3ec5"));

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: new Guid("27f86ad1-1754-4b92-9bc9-7fe58ce3d959"));

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: new Guid("6e7dec25-01ae-480b-bf78-bc482d338c5d"));

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: new Guid("a5e062a0-3651-4675-ad4d-b4265bc5f6c5"));

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: new Guid("fe35dce8-a006-4fdf-8b6b-3ce150a7f07d"));

            migrationBuilder.InsertData(
                table: "ActivitiesType",
                columns: new[] { "ActivityTypeId", "TypeName" },
                values: new object[,]
                {
                    { new Guid("10c5c378-58df-4449-8826-c38a49037015"), "Workshop" },
                    { new Guid("1e0b3e2b-4230-4bac-b01d-d3c41aa8a098"), "Email" },
                    { new Guid("2ceddafc-c6bf-4c6f-816b-a715ddda7a89"), "Meeting" },
                    { new Guid("33e98c67-4b47-4b32-ab66-507887dc039f"), "Call" },
                    { new Guid("3654800c-52b9-4b07-a9cb-630aa3f719c1"), "Demo" },
                    { new Guid("37c1837a-27b4-471d-9c18-97954eb2a42a"), "Note" },
                    { new Guid("5f478274-ac85-4514-9629-4e30a6062415"), "Presentation" },
                    { new Guid("91ba2708-7e97-4879-b914-a9a6d4544fb7"), "Training" },
                    { new Guid("c62a3860-8c2f-480b-9716-80ec6b40864b"), "Follow-up" },
                    { new Guid("c686a8e7-0140-4a82-9c1e-8820aad011e3"), "Other" },
                    { new Guid("e0921ac9-f1c1-4e53-bdad-dff4f83ca442"), "Webinar" },
                    { new Guid("f8f57284-59d3-4803-8470-71fc4153541a"), "Task" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "City", "CompanyAddress", "CompanyEmailAddress", "CompanyName", "CompanyPhoneNumber", "Country", "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("a6910354-dee7-4b00-b551-1d577d5d90a3"), "Cupertino", "Cupertino, California", "apple.example@example.com", "Apple", "123456780", "USA", new DateTime(2024, 4, 29, 15, 44, 40, 193, DateTimeKind.Local).AddTicks(7540), null, null, null },
                    { new Guid("e631df5b-70fe-4bdd-bbe2-f382fd44399b"), "Redmond", "Redmond, Washington", "microsoft.example@example.com", "Microsoft", "123456789", "USA", new DateTime(2024, 4, 29, 15, 44, 40, 193, DateTimeKind.Local).AddTicks(7537), null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "CreatedAt", "CreatedBy", "Email", "FirstName", "FkCompanyId", "FkCustomerId", "LastName", "PhoneNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("c6eb4cfb-54c6-460c-afe7-22a8c94e48c5"), new DateTime(2024, 4, 29, 15, 44, 40, 193, DateTimeKind.Local).AddTicks(7557), null, "anna.banana@example.com", "Anna", null, null, "Banana", "123456789", null, null });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "City", "Country", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "PhoneNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("6bdaee29-96c7-421a-9de5-cab6a2961000"), "California", "USA", new DateTime(2024, 4, 29, 15, 44, 40, 193, DateTimeKind.Local).AddTicks(7444), null, "maria.rosa@example.com", "Maria", "Rosa", "123456780", null, null },
                    { new Guid("7a10bdeb-c80c-4359-aab3-f633c0bd6dea"), "New York", "USA", new DateTime(2024, 4, 29, 15, 44, 40, 193, DateTimeKind.Local).AddTicks(7387), null, "john.doe@example.com", "John", "Doe", "123456789", null, null }
                });

            migrationBuilder.InsertData(
                table: "DealsStatus",
                columns: new[] { "DealStatusId", "StatusName" },
                values: new object[,]
                {
                    { new Guid("221d676a-a921-4a0b-ac70-c0fd28d3628f"), "On Hold" },
                    { new Guid("57913308-bef9-4a0a-9849-541d9e6c9fca"), "New" },
                    { new Guid("750e4dac-eec3-4f6a-806e-ba037f68a635"), "Closed Won" },
                    { new Guid("b2cac70d-747b-4d7f-8881-650f3f5c8e2e"), "Closed Lost" },
                    { new Guid("e2a73c53-0432-4353-82c7-79b5503dfe70"), "In Progress" }
                });

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "PriorityId", "PriorityName" },
                values: new object[,]
                {
                    { new Guid("2dc429d8-5766-45ef-855e-8fa81e8d0803"), "Low" },
                    { new Guid("40b3ab77-6145-4cc9-9c7a-5fbff41f15ee"), "Urgent" },
                    { new Guid("5268a485-6490-4fb9-8095-8de6bfb9b65d"), "High" },
                    { new Guid("d8b9d728-fc51-40b5-9da0-8a21a4566711"), "Medium" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("10c5c378-58df-4449-8826-c38a49037015"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("1e0b3e2b-4230-4bac-b01d-d3c41aa8a098"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("2ceddafc-c6bf-4c6f-816b-a715ddda7a89"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("33e98c67-4b47-4b32-ab66-507887dc039f"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("3654800c-52b9-4b07-a9cb-630aa3f719c1"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("37c1837a-27b4-471d-9c18-97954eb2a42a"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("5f478274-ac85-4514-9629-4e30a6062415"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("91ba2708-7e97-4879-b914-a9a6d4544fb7"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("c62a3860-8c2f-480b-9716-80ec6b40864b"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("c686a8e7-0140-4a82-9c1e-8820aad011e3"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("e0921ac9-f1c1-4e53-bdad-dff4f83ca442"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("f8f57284-59d3-4803-8470-71fc4153541a"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("a6910354-dee7-4b00-b551-1d577d5d90a3"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("e631df5b-70fe-4bdd-bbe2-f382fd44399b"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: new Guid("c6eb4cfb-54c6-460c-afe7-22a8c94e48c5"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("6bdaee29-96c7-421a-9de5-cab6a2961000"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("7a10bdeb-c80c-4359-aab3-f633c0bd6dea"));

            migrationBuilder.DeleteData(
                table: "DealsStatus",
                keyColumn: "DealStatusId",
                keyValue: new Guid("221d676a-a921-4a0b-ac70-c0fd28d3628f"));

            migrationBuilder.DeleteData(
                table: "DealsStatus",
                keyColumn: "DealStatusId",
                keyValue: new Guid("57913308-bef9-4a0a-9849-541d9e6c9fca"));

            migrationBuilder.DeleteData(
                table: "DealsStatus",
                keyColumn: "DealStatusId",
                keyValue: new Guid("750e4dac-eec3-4f6a-806e-ba037f68a635"));

            migrationBuilder.DeleteData(
                table: "DealsStatus",
                keyColumn: "DealStatusId",
                keyValue: new Guid("b2cac70d-747b-4d7f-8881-650f3f5c8e2e"));

            migrationBuilder.DeleteData(
                table: "DealsStatus",
                keyColumn: "DealStatusId",
                keyValue: new Guid("e2a73c53-0432-4353-82c7-79b5503dfe70"));

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: new Guid("2dc429d8-5766-45ef-855e-8fa81e8d0803"));

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: new Guid("40b3ab77-6145-4cc9-9c7a-5fbff41f15ee"));

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: new Guid("5268a485-6490-4fb9-8095-8de6bfb9b65d"));

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: new Guid("d8b9d728-fc51-40b5-9da0-8a21a4566711"));

            migrationBuilder.InsertData(
                table: "ActivitiesType",
                columns: new[] { "ActivityTypeId", "TypeName" },
                values: new object[,]
                {
                    { new Guid("0c893744-89f5-4f2d-b645-360905393263"), "Call" },
                    { new Guid("10ee2ad7-aae8-4d3b-9eb1-046a0d3a868e"), "Note" },
                    { new Guid("217cfa8a-b17e-49d6-853d-3ad31b31ed67"), "Presentation" },
                    { new Guid("23d645a4-ac7d-4848-981a-912dabaa6f9d"), "Webinar" },
                    { new Guid("2efdc879-ba6d-47c0-b0d7-fd76f1211b56"), "Demo" },
                    { new Guid("3b712953-1d1c-479c-ab3d-06dc18d1b67e"), "Follow-up" },
                    { new Guid("642395cb-e8c1-45e3-8803-7991623c999e"), "Workshop" },
                    { new Guid("6ababab1-eb42-4f7c-960f-0a0968a5d87b"), "Other" },
                    { new Guid("7919f416-d8fd-4f2a-a301-63a4fc6939d8"), "Training" },
                    { new Guid("7df96bf7-fc6d-4ecc-9467-74a7797c5432"), "Meeting" },
                    { new Guid("823ae74e-cbe2-4399-a3ce-5eeb66803d69"), "Task" },
                    { new Guid("eb484760-8651-4112-9dc1-1a81cce48ca6"), "Email" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "City", "CompanyAddress", "CompanyEmailAddress", "CompanyName", "CompanyPhoneNumber", "Country", "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("84f38628-e598-490e-861b-e41a1b125e13"), "Redmond", "Redmond, Washington", "microsoft.example@example.com", "Microsoft", "123456789", "USA", new DateTime(2024, 4, 29, 15, 42, 52, 759, DateTimeKind.Local).AddTicks(2701), null, null, null },
                    { new Guid("cd4959ef-4c78-4bdd-997c-758e4bc77aac"), "Cupertino", "Cupertino, California", "apple.example@example.com", "Apple", "123456780", "USA", new DateTime(2024, 4, 29, 15, 42, 52, 759, DateTimeKind.Local).AddTicks(2704), null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "CreatedAt", "CreatedBy", "Email", "FirstName", "FkCompanyId", "FkCustomerId", "LastName", "PhoneNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("49c40adb-34a4-4a2a-af5f-c49a39c85b25"), new DateTime(2024, 4, 29, 15, 42, 52, 759, DateTimeKind.Local).AddTicks(2722), null, "anna.banana@example.com", "Anna", null, null, "Banana", "123456789", null, null });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "City", "Country", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "PhoneNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("2126d2d4-1d82-4c34-8b5b-7ed6c20adc60"), "California", "USA", new DateTime(2024, 4, 29, 15, 42, 52, 759, DateTimeKind.Local).AddTicks(2595), null, "maria.rosa@example.com", "Maria", "Rosa", "123456780", null, null },
                    { new Guid("ca4d16f5-8baa-42da-bdca-5d021a95e9ee"), "New York", "USA", new DateTime(2024, 4, 29, 15, 42, 52, 759, DateTimeKind.Local).AddTicks(2549), null, "john.doe@example.com", "John", "Doe", "123456789", null, null }
                });

            migrationBuilder.InsertData(
                table: "DealsStatus",
                columns: new[] { "DealStatusId", "StatusName" },
                values: new object[,]
                {
                    { new Guid("12283029-d4e0-4dbc-8821-e5535d84bc87"), "In Progress" },
                    { new Guid("1a8ede24-4344-4185-ae6d-546ec12dca15"), "Closed Won" },
                    { new Guid("3185e235-7a2d-4dab-a7ff-2ca4cf93eb24"), "Closed Lost" },
                    { new Guid("797bb361-cbec-4f4d-a8d4-33d733eb4dfd"), "New" },
                    { new Guid("ed766399-4edb-4dc7-a63d-d7bdd05c3ec5"), "On Hold" }
                });

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "PriorityId", "PriorityName" },
                values: new object[,]
                {
                    { new Guid("27f86ad1-1754-4b92-9bc9-7fe58ce3d959"), "Medium" },
                    { new Guid("6e7dec25-01ae-480b-bf78-bc482d338c5d"), "High" },
                    { new Guid("a5e062a0-3651-4675-ad4d-b4265bc5f6c5"), "Low" },
                    { new Guid("fe35dce8-a006-4fdf-8b6b-3ce150a7f07d"), "Urgent" }
                });
        }
    }
}
