using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FlowCRM.Migrations
{
    /// <inheritdoc />
    public partial class NullableFkDealsTrue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deals_Companies_FkCompanyId",
                table: "Deals");

            migrationBuilder.DropForeignKey(
                name: "FK_Deals_Customers_FkCustomerId",
                table: "Deals");

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("1014ba5f-956f-4337-8298-183cf90689d0"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("19f2d202-4aca-4e38-9d44-ebd5cd48759f"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("4a5acb80-3604-414f-8193-022bb1e8818d"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("52a48c07-4f23-4f8b-ae2d-b11807f19401"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("5c9c45ab-a7cf-40f2-8480-d919167a09cc"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("61d87deb-8c8b-44a8-a089-f4ecd49f77ac"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("76d876e7-8071-4e25-b140-c666ba9f3fad"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("7f16ad6b-4535-4f73-9b8d-8a4cdc575a92"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("8850d140-97f4-4797-9046-693c502ddbd8"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("ad566fa3-5d3a-4301-b045-55a312e0c404"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("d9202c87-2ab7-420b-8f88-2789a452a562"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("fe7c0f48-0f7c-40a9-89eb-44405805ca72"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("12d1cb90-73e4-4539-b782-b33262c846eb"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("cde5e196-4d4b-48c2-b553-fe90a1130fca"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: new Guid("b517729b-ee99-4c2b-9ea2-5d5823d665b1"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("41d19961-5fea-4d0f-9b1d-3bbf40252d4d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("724f7abe-61c3-4a17-bd0a-df048e1bb268"));

            migrationBuilder.DeleteData(
                table: "DealsStatus",
                keyColumn: "DealStatusId",
                keyValue: new Guid("14a4a7e7-f113-4419-958a-2348d3052a05"));

            migrationBuilder.DeleteData(
                table: "DealsStatus",
                keyColumn: "DealStatusId",
                keyValue: new Guid("40a61f50-04c6-46ac-b2e3-e92fed23c41d"));

            migrationBuilder.DeleteData(
                table: "DealsStatus",
                keyColumn: "DealStatusId",
                keyValue: new Guid("52caff7e-ab5c-4956-b5ee-070488aa7d90"));

            migrationBuilder.DeleteData(
                table: "DealsStatus",
                keyColumn: "DealStatusId",
                keyValue: new Guid("69d12268-f556-401b-9d77-12fcab86a109"));

            migrationBuilder.DeleteData(
                table: "DealsStatus",
                keyColumn: "DealStatusId",
                keyValue: new Guid("c51c1606-4456-4345-a50b-28721123a6e4"));

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: new Guid("1d91059e-6ed1-4fb6-aa76-1f8462a9d817"));

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: new Guid("7b645287-ff7e-4ae7-b644-26032ef6e0db"));

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: new Guid("89892795-da61-46d2-99b9-34e71f9c9a53"));

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: new Guid("90ae0606-4303-431f-b729-fdfce1174e16"));

            migrationBuilder.AlterColumn<Guid>(
                name: "FkCustomerId",
                table: "Deals",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "FkCompanyId",
                table: "Deals",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deals_Companies_FkCompanyId",
                table: "Deals");

            migrationBuilder.DropForeignKey(
                name: "FK_Deals_Customers_FkCustomerId",
                table: "Deals");

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

            migrationBuilder.AlterColumn<Guid>(
                name: "FkCustomerId",
                table: "Deals",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "FkCompanyId",
                table: "Deals",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "ActivitiesType",
                columns: new[] { "ActivityTypeId", "TypeName" },
                values: new object[,]
                {
                    { new Guid("1014ba5f-956f-4337-8298-183cf90689d0"), "Workshop" },
                    { new Guid("19f2d202-4aca-4e38-9d44-ebd5cd48759f"), "Meeting" },
                    { new Guid("4a5acb80-3604-414f-8193-022bb1e8818d"), "Email" },
                    { new Guid("52a48c07-4f23-4f8b-ae2d-b11807f19401"), "Training" },
                    { new Guid("5c9c45ab-a7cf-40f2-8480-d919167a09cc"), "Note" },
                    { new Guid("61d87deb-8c8b-44a8-a089-f4ecd49f77ac"), "Task" },
                    { new Guid("76d876e7-8071-4e25-b140-c666ba9f3fad"), "Presentation" },
                    { new Guid("7f16ad6b-4535-4f73-9b8d-8a4cdc575a92"), "Follow-up" },
                    { new Guid("8850d140-97f4-4797-9046-693c502ddbd8"), "Other" },
                    { new Guid("ad566fa3-5d3a-4301-b045-55a312e0c404"), "Call" },
                    { new Guid("d9202c87-2ab7-420b-8f88-2789a452a562"), "Demo" },
                    { new Guid("fe7c0f48-0f7c-40a9-89eb-44405805ca72"), "Webinar" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "City", "CompanyAddress", "CompanyEmailAddress", "CompanyName", "CompanyPhoneNumber", "Country", "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("12d1cb90-73e4-4539-b782-b33262c846eb"), "Cupertino", "Cupertino, California", "apple.example@example.com", "Apple", "123456780", "USA", new DateTime(2024, 5, 13, 18, 58, 56, 168, DateTimeKind.Local).AddTicks(2839), null, null, null },
                    { new Guid("cde5e196-4d4b-48c2-b553-fe90a1130fca"), "Redmond", "Redmond, Washington", "microsoft.example@example.com", "Microsoft", "123456789", "USA", new DateTime(2024, 5, 13, 18, 58, 56, 168, DateTimeKind.Local).AddTicks(2821), null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "CreatedAt", "CreatedBy", "Email", "FirstName", "FkCompanyId", "FkCustomerId", "LastName", "PhoneNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("b517729b-ee99-4c2b-9ea2-5d5823d665b1"), new DateTime(2024, 5, 13, 18, 58, 56, 168, DateTimeKind.Local).AddTicks(2926), null, "anna.banana@example.com", "Anna", null, null, "Banana", "123456789", null, null });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "City", "Country", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "PhoneNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("41d19961-5fea-4d0f-9b1d-3bbf40252d4d"), "New York", "USA", new DateTime(2024, 5, 13, 18, 58, 56, 168, DateTimeKind.Local).AddTicks(2270), null, "john.doe@example.com", "John", "Doe", "123456789", null, null },
                    { new Guid("724f7abe-61c3-4a17-bd0a-df048e1bb268"), "California", "USA", new DateTime(2024, 5, 13, 18, 58, 56, 168, DateTimeKind.Local).AddTicks(2373), null, "maria.rosa@example.com", "Maria", "Rosa", "123456780", null, null }
                });

            migrationBuilder.InsertData(
                table: "DealsStatus",
                columns: new[] { "DealStatusId", "StatusName" },
                values: new object[,]
                {
                    { new Guid("14a4a7e7-f113-4419-958a-2348d3052a05"), "In Progress" },
                    { new Guid("40a61f50-04c6-46ac-b2e3-e92fed23c41d"), "Closed Won" },
                    { new Guid("52caff7e-ab5c-4956-b5ee-070488aa7d90"), "Closed Lost" },
                    { new Guid("69d12268-f556-401b-9d77-12fcab86a109"), "New" },
                    { new Guid("c51c1606-4456-4345-a50b-28721123a6e4"), "On Hold" }
                });

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "PriorityId", "PriorityName" },
                values: new object[,]
                {
                    { new Guid("1d91059e-6ed1-4fb6-aa76-1f8462a9d817"), "Low" },
                    { new Guid("7b645287-ff7e-4ae7-b644-26032ef6e0db"), "Medium" },
                    { new Guid("89892795-da61-46d2-99b9-34e71f9c9a53"), "High" },
                    { new Guid("90ae0606-4303-431f-b729-fdfce1174e16"), "Urgent" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Deals_Companies_FkCompanyId",
                table: "Deals",
                column: "FkCompanyId",
                principalTable: "Companies",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Deals_Customers_FkCustomerId",
                table: "Deals",
                column: "FkCustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
