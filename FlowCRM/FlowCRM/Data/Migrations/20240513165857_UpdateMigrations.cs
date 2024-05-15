using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FlowCRM.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Companies_FkCompanyId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Deals_Companies_FkCompanyId",
                table: "Deals");

            migrationBuilder.DropForeignKey(
                name: "FK_Deals_Customers_FkCustomerId",
                table: "Deals");

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("06bd7ce0-2b1e-4de4-b50a-c72e3b6518fc"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("187b1ba8-10c0-4be8-b694-e37329da6651"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("2e6c9aa2-712e-4d9f-b1bb-f0ee313ff72b"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("3803f5d6-3f37-4a1f-a6fa-75c3b0d59f15"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("525992df-3bf0-4f54-acd2-a89985be4fa2"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("8b07ecfe-a42c-4867-9cda-0a8bbfde855d"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("9d7236bf-85ae-4edb-a756-eb81ef96e6ab"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("a2b5110f-f7e5-44c6-b523-aca1c8fb4101"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("a8674988-5275-4d95-a97f-aff53876cfbf"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("c3681114-480f-4079-9ecd-604d4fb1e4aa"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("cb82ed72-7b6f-4d9e-9fd7-2d44ca7ad09f"));

            migrationBuilder.DeleteData(
                table: "ActivitiesType",
                keyColumn: "ActivityTypeId",
                keyValue: new Guid("ddf860e5-3ca9-483b-acfa-37dc1c01fa1c"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("222373a7-b1fe-4418-910c-2a36cb43f105"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("4f27099c-79c8-4c27-b7f8-737d78772241"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: new Guid("5e27fb99-b03e-4409-86b3-6f3e4d0b8161"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("aa8307df-fb37-432c-83f6-8c58d7b7327d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("da195463-16f7-49d4-86fa-e167768da160"));

            migrationBuilder.DeleteData(
                table: "DealsStatus",
                keyColumn: "DealStatusId",
                keyValue: new Guid("3099f10d-fb19-46e2-83bd-9f11ed5a0a9c"));

            migrationBuilder.DeleteData(
                table: "DealsStatus",
                keyColumn: "DealStatusId",
                keyValue: new Guid("6bb6b516-0ad6-46ef-953a-4b0b2946aa79"));

            migrationBuilder.DeleteData(
                table: "DealsStatus",
                keyColumn: "DealStatusId",
                keyValue: new Guid("6e050d24-37ae-4ee2-8975-66a91989e517"));

            migrationBuilder.DeleteData(
                table: "DealsStatus",
                keyColumn: "DealStatusId",
                keyValue: new Guid("cfa3249a-9745-4dfa-90eb-8a5719bbefe8"));

            migrationBuilder.DeleteData(
                table: "DealsStatus",
                keyColumn: "DealStatusId",
                keyValue: new Guid("d9578f56-9888-4b80-b264-b9ac21ea9b54"));

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: new Guid("79fd508a-8625-4a8c-baea-ecff76cedced"));

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: new Guid("c1888f96-ad8b-4591-aa1e-f2dff7caee32"));

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: new Guid("c9e40828-fd60-4cc1-913e-2c738adc42b0"));

            migrationBuilder.DeleteData(
                table: "Priorities",
                keyColumn: "PriorityId",
                keyValue: new Guid("e5f0281e-c059-4f72-b604-14228ce277af"));

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

            migrationBuilder.AlterColumn<DateOnly>(
                name: "ActivityDate",
                table: "Activities",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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
                name: "FK_Contacts_Companies_FkCompanyId",
                table: "Contacts",
                column: "FkCompanyId",
                principalTable: "Companies",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Companies_FkCompanyId",
                table: "Contacts");

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

            migrationBuilder.AlterColumn<DateTime>(
                name: "ActivityDate",
                table: "Activities",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.InsertData(
                table: "ActivitiesType",
                columns: new[] { "ActivityTypeId", "TypeName" },
                values: new object[,]
                {
                    { new Guid("06bd7ce0-2b1e-4de4-b50a-c72e3b6518fc"), "Workshop" },
                    { new Guid("187b1ba8-10c0-4be8-b694-e37329da6651"), "Demo" },
                    { new Guid("2e6c9aa2-712e-4d9f-b1bb-f0ee313ff72b"), "Webinar" },
                    { new Guid("3803f5d6-3f37-4a1f-a6fa-75c3b0d59f15"), "Other" },
                    { new Guid("525992df-3bf0-4f54-acd2-a89985be4fa2"), "Email" },
                    { new Guid("8b07ecfe-a42c-4867-9cda-0a8bbfde855d"), "Presentation" },
                    { new Guid("9d7236bf-85ae-4edb-a756-eb81ef96e6ab"), "Meeting" },
                    { new Guid("a2b5110f-f7e5-44c6-b523-aca1c8fb4101"), "Call" },
                    { new Guid("a8674988-5275-4d95-a97f-aff53876cfbf"), "Task" },
                    { new Guid("c3681114-480f-4079-9ecd-604d4fb1e4aa"), "Training" },
                    { new Guid("cb82ed72-7b6f-4d9e-9fd7-2d44ca7ad09f"), "Note" },
                    { new Guid("ddf860e5-3ca9-483b-acfa-37dc1c01fa1c"), "Follow-up" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "City", "CompanyAddress", "CompanyEmailAddress", "CompanyName", "CompanyPhoneNumber", "Country", "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("222373a7-b1fe-4418-910c-2a36cb43f105"), "Cupertino", "Cupertino, California", "apple.example@example.com", "Apple", "123456780", "USA", new DateTime(2024, 5, 2, 17, 32, 43, 450, DateTimeKind.Local).AddTicks(2875), null, null, null },
                    { new Guid("4f27099c-79c8-4c27-b7f8-737d78772241"), "Redmond", "Redmond, Washington", "microsoft.example@example.com", "Microsoft", "123456789", "USA", new DateTime(2024, 5, 2, 17, 32, 43, 450, DateTimeKind.Local).AddTicks(2872), null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "CreatedAt", "CreatedBy", "Email", "FirstName", "FkCompanyId", "FkCustomerId", "LastName", "PhoneNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("5e27fb99-b03e-4409-86b3-6f3e4d0b8161"), new DateTime(2024, 5, 2, 17, 32, 43, 450, DateTimeKind.Local).AddTicks(2894), null, "anna.banana@example.com", "Anna", null, null, "Banana", "123456789", null, null });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "City", "Country", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "PhoneNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("aa8307df-fb37-432c-83f6-8c58d7b7327d"), "New York", "USA", new DateTime(2024, 5, 2, 17, 32, 43, 450, DateTimeKind.Local).AddTicks(2705), null, "john.doe@example.com", "John", "Doe", "123456789", null, null },
                    { new Guid("da195463-16f7-49d4-86fa-e167768da160"), "California", "USA", new DateTime(2024, 5, 2, 17, 32, 43, 450, DateTimeKind.Local).AddTicks(2757), null, "maria.rosa@example.com", "Maria", "Rosa", "123456780", null, null }
                });

            migrationBuilder.InsertData(
                table: "DealsStatus",
                columns: new[] { "DealStatusId", "StatusName" },
                values: new object[,]
                {
                    { new Guid("3099f10d-fb19-46e2-83bd-9f11ed5a0a9c"), "On Hold" },
                    { new Guid("6bb6b516-0ad6-46ef-953a-4b0b2946aa79"), "Closed Won" },
                    { new Guid("6e050d24-37ae-4ee2-8975-66a91989e517"), "Closed Lost" },
                    { new Guid("cfa3249a-9745-4dfa-90eb-8a5719bbefe8"), "In Progress" },
                    { new Guid("d9578f56-9888-4b80-b264-b9ac21ea9b54"), "New" }
                });

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "PriorityId", "PriorityName" },
                values: new object[,]
                {
                    { new Guid("79fd508a-8625-4a8c-baea-ecff76cedced"), "Low" },
                    { new Guid("c1888f96-ad8b-4591-aa1e-f2dff7caee32"), "Urgent" },
                    { new Guid("c9e40828-fd60-4cc1-913e-2c738adc42b0"), "High" },
                    { new Guid("e5f0281e-c059-4f72-b604-14228ce277af"), "Medium" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Companies_FkCompanyId",
                table: "Contacts",
                column: "FkCompanyId",
                principalTable: "Companies",
                principalColumn: "CompanyId");

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
    }
}
