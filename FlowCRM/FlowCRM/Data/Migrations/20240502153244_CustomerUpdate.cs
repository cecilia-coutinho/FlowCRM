using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FlowCRM.Migrations
{
    /// <inheritdoc />
    public partial class CustomerUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
