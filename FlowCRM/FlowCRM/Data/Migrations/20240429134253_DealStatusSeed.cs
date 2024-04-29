using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FlowCRM.Migrations
{
    /// <inheritdoc />
    public partial class DealStatusSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("0c988d6b-6086-416d-8ac4-a1d10c61a231"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("356daeeb-b5c9-4508-94e6-c7770c754429"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("4e722234-4be2-4e11-8c7c-3408146e3f7f"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("4f7f545d-b28c-408d-80ab-3842d48d109a"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("545f5e79-f816-4de4-add2-fce4ff6dd97e"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("61e33326-11cd-4839-8818-b8704780a419"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("63b9fb0c-3ee0-4614-8383-fae2f486bf16"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("6c08a6ea-f20f-4b78-9da0-dc31e67cdc76"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("8fb48347-7fcb-405c-a7e7-4e83c8ac620f"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("b98f76d8-1f65-4d15-8d80-908ca033eabe"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("e8ba0da4-2d6a-4d34-8f90-2aefa1cc55de"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("f4ac0410-e885-4626-a053-a0063012f8c8"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("6c94469b-fa69-4e90-b3d3-eefe335cf5b0"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("a4eff66b-76a9-434d-adeb-856a724d7940"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: new Guid("2a95f15e-32fd-44f5-837a-0717959d9a7a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("b7079450-3d0a-4fc3-b945-181a5145b16c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("ba891aaf-96e4-4f90-a5f4-771d78830934"));

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: new Guid("5c532e0f-f74e-428e-a8f5-abb9b4744842"));

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: new Guid("75d54530-033b-4e3f-87a8-da6f4ebbda90"));

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: new Guid("b146cfc9-f2a2-4a3b-a9b3-ae880c549333"));

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: new Guid("cb8de546-380f-40d6-985f-68eeddc17daf"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("0c988d6b-6086-416d-8ac4-a1d10c61a231"), "Demo" },
                    { new Guid("356daeeb-b5c9-4508-94e6-c7770c754429"), "Meeting" },
                    { new Guid("4e722234-4be2-4e11-8c7c-3408146e3f7f"), "Training" },
                    { new Guid("4f7f545d-b28c-408d-80ab-3842d48d109a"), "Follow-up" },
                    { new Guid("545f5e79-f816-4de4-add2-fce4ff6dd97e"), "Note" },
                    { new Guid("61e33326-11cd-4839-8818-b8704780a419"), "Call" },
                    { new Guid("63b9fb0c-3ee0-4614-8383-fae2f486bf16"), "Workshop" },
                    { new Guid("6c08a6ea-f20f-4b78-9da0-dc31e67cdc76"), "Email" },
                    { new Guid("8fb48347-7fcb-405c-a7e7-4e83c8ac620f"), "Webinar" },
                    { new Guid("b98f76d8-1f65-4d15-8d80-908ca033eabe"), "Presentation" },
                    { new Guid("e8ba0da4-2d6a-4d34-8f90-2aefa1cc55de"), "Other" },
                    { new Guid("f4ac0410-e885-4626-a053-a0063012f8c8"), "Task" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "City", "CompanyAddress", "CompanyEmailAddress", "CompanyName", "CompanyPhoneNumber", "Country", "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("6c94469b-fa69-4e90-b3d3-eefe335cf5b0"), "Cupertino", "Cupertino, California", "apple.example@example.com", "Apple", "123456780", "USA", new DateTime(2024, 4, 29, 14, 33, 8, 942, DateTimeKind.Local).AddTicks(2923), null, null, null },
                    { new Guid("a4eff66b-76a9-434d-adeb-856a724d7940"), "Redmond", "Redmond, Washington", "microsoft.example@example.com", "Microsoft", "123456789", "USA", new DateTime(2024, 4, 29, 14, 33, 8, 942, DateTimeKind.Local).AddTicks(2918), null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "CreatedAt", "CreatedBy", "Email", "FirstName", "FkCompanyId", "FkCustomerId", "LastName", "PhoneNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("2a95f15e-32fd-44f5-837a-0717959d9a7a"), new DateTime(2024, 4, 29, 14, 33, 8, 942, DateTimeKind.Local).AddTicks(2942), null, "anna.banana@example.com", "Anna", null, null, "Banana", "123456789", null, null });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "City", "Country", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "PhoneNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("b7079450-3d0a-4fc3-b945-181a5145b16c"), "California", "USA", new DateTime(2024, 4, 29, 14, 33, 8, 942, DateTimeKind.Local).AddTicks(2817), null, "maria.rosa@example.com", "Maria", "Rosa", "123456780", null, null },
                    { new Guid("ba891aaf-96e4-4f90-a5f4-771d78830934"), "New York", "USA", new DateTime(2024, 4, 29, 14, 33, 8, 942, DateTimeKind.Local).AddTicks(2764), null, "john.doe@example.com", "John", "Doe", "123456789", null, null }
                });

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "PriorityId", "PriorityName" },
                values: new object[,]
                {
                    { new Guid("5c532e0f-f74e-428e-a8f5-abb9b4744842"), "High" },
                    { new Guid("75d54530-033b-4e3f-87a8-da6f4ebbda90"), "Medium" },
                    { new Guid("b146cfc9-f2a2-4a3b-a9b3-ae880c549333"), "Low" },
                    { new Guid("cb8de546-380f-40d6-985f-68eeddc17daf"), "Urgent" }
                });
        }
    }
}
