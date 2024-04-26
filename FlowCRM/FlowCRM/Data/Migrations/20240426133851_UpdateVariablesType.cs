using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FlowCRM.Migrations
{
    /// <inheritdoc />
    public partial class UpdateVariablesType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Leads",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Leads",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Deals",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Deals",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Activities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Activities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedBy",
                table: "Leads",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedBy",
                table: "Leads",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedBy",
                table: "Deals",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedBy",
                table: "Deals",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedBy",
                table: "Customers",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedBy",
                table: "Customers",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedBy",
                table: "Contacts",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedBy",
                table: "Contacts",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedBy",
                table: "Companies",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedBy",
                table: "Companies",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedBy",
                table: "Activities",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedBy",
                table: "Activities",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
