using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FlowCRM.Migrations
{
    /// <inheritdoc />
    public partial class NewVariableDeal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("09924757-10bc-4383-977d-7f5f8291e605"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("0dfc1432-735d-4ed5-ad89-04d2611e7ff0"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("23883b0a-4843-4d1a-8e5b-b6a309766f74"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("4deb2444-2b3b-4a92-8450-0446f6fb1b54"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("771eb53c-d01f-42bc-9a60-bfa40d11696e"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("78bc53d2-8b1b-4b5d-897c-c44ce89e9017"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("b1ca2a80-3bdb-4846-946b-ace812e66f3d"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("c74cbfba-3d32-4cd6-b274-11b957101bae"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("da581035-4f44-47c7-a205-e3cc96461a52"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("e159bf8d-2158-4402-9aea-95baac77e3f6"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("e38323cd-7a5b-4fbc-b974-f86ea4eae819"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("f81efac2-521d-4c4a-870a-512a758dd671"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("245b144e-da37-4793-bafa-faeafd971380"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("ab587bc6-04e1-4301-9e2f-62fdc4931b0b"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: new Guid("1dd2040f-f3bf-4ee1-81a4-315cdeec91f5"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("24579d01-79ef-4627-9cbf-4711c0b60c58"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("a61d767f-bd03-407b-8018-f3b0d638fbc3"));

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: new Guid("02853e81-82c6-489d-a03d-57281724f131"));

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: new Guid("2fec1d2b-b41a-4ac6-9b64-6e3bbe64714e"));

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: new Guid("d42caed6-a980-44f9-b0b2-28e782c19452"));

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: new Guid("da8a688b-6302-487e-8843-e4f41384a247"));

            migrationBuilder.AddColumn<string>(
                name: "DealName",
                table: "Deals",
                type: "nvarchar(450)",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Deals_DealName",
                table: "Deals",
                column: "DealName",
                unique: true,
                filter: "[DealName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Deals_DealName",
                table: "Deals");

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

            migrationBuilder.DropColumn(
                name: "DealName",
                table: "Deals");

            migrationBuilder.InsertData(
                table: "ActivitiesType",
                columns: new[] { "ActivityTypeId", "TypeName" },
                values: new object[,]
                {
                    { new Guid("09924757-10bc-4383-977d-7f5f8291e605"), "Meeting" },
                    { new Guid("0dfc1432-735d-4ed5-ad89-04d2611e7ff0"), "Presentation" },
                    { new Guid("23883b0a-4843-4d1a-8e5b-b6a309766f74"), "Webinar" },
                    { new Guid("4deb2444-2b3b-4a92-8450-0446f6fb1b54"), "Email" },
                    { new Guid("771eb53c-d01f-42bc-9a60-bfa40d11696e"), "Other" },
                    { new Guid("78bc53d2-8b1b-4b5d-897c-c44ce89e9017"), "Call" },
                    { new Guid("b1ca2a80-3bdb-4846-946b-ace812e66f3d"), "Note" },
                    { new Guid("c74cbfba-3d32-4cd6-b274-11b957101bae"), "Workshop" },
                    { new Guid("da581035-4f44-47c7-a205-e3cc96461a52"), "Demo" },
                    { new Guid("e159bf8d-2158-4402-9aea-95baac77e3f6"), "Follow-up" },
                    { new Guid("e38323cd-7a5b-4fbc-b974-f86ea4eae819"), "Task" },
                    { new Guid("f81efac2-521d-4c4a-870a-512a758dd671"), "Training" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "City", "CompanyAddress", "CompanyEmailAddress", "CompanyName", "CompanyPhoneNumber", "Country", "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("245b144e-da37-4793-bafa-faeafd971380"), "Redmond", "Redmond, Washington", "microsoft.example@example.com", "Microsoft", "123456789", "USA", new DateTime(2024, 4, 26, 15, 38, 50, 779, DateTimeKind.Local).AddTicks(1051), null, null, null },
                    { new Guid("ab587bc6-04e1-4301-9e2f-62fdc4931b0b"), "Cupertino", "Cupertino, California", "apple.example@example.com", "Apple", "123456780", "USA", new DateTime(2024, 4, 26, 15, 38, 50, 779, DateTimeKind.Local).AddTicks(1055), null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "CreatedAt", "CreatedBy", "Email", "FirstName", "FkCompanyId", "FkCustomerId", "LastName", "PhoneNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("1dd2040f-f3bf-4ee1-81a4-315cdeec91f5"), new DateTime(2024, 4, 26, 15, 38, 50, 779, DateTimeKind.Local).AddTicks(1072), null, "anna.banana@example.com", "Anna", null, null, "Banana", "123456789", null, null });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "City", "Country", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "PhoneNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("24579d01-79ef-4627-9cbf-4711c0b60c58"), "California", "USA", new DateTime(2024, 4, 26, 15, 38, 50, 779, DateTimeKind.Local).AddTicks(950), null, "maria.rosa@example.com", "Maria", "Rosa", "123456780", null, null },
                    { new Guid("a61d767f-bd03-407b-8018-f3b0d638fbc3"), "New York", "USA", new DateTime(2024, 4, 26, 15, 38, 50, 779, DateTimeKind.Local).AddTicks(902), null, "john.doe@example.com", "John", "Doe", "123456789", null, null }
                });

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "PriorityId", "PriorityName" },
                values: new object[,]
                {
                    { new Guid("02853e81-82c6-489d-a03d-57281724f131"), "Medium" },
                    { new Guid("2fec1d2b-b41a-4ac6-9b64-6e3bbe64714e"), "High" },
                    { new Guid("d42caed6-a980-44f9-b0b2-28e782c19452"), "Urgent" },
                    { new Guid("da8a688b-6302-487e-8843-e4f41384a247"), "Low" }
                });
        }
    }
}
