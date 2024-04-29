using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FlowCRM.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("0c632803-e079-417d-a67d-c809ef3a8b8c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: new Guid("9530287f-5ab3-4692-b861-c1db40a30196"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "Customers",
                columns: new[] { "CustomerId", "City", "Country", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastName", "PhoneNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0c632803-e079-417d-a67d-c809ef3a8b8c"), "California", "USA", new DateTime(2024, 4, 24, 15, 23, 58, 981, DateTimeKind.Local).AddTicks(5670), null, "maria.rosa@example.com", "Maria", "Rosa", "123456780", null, null },
                    { new Guid("9530287f-5ab3-4692-b861-c1db40a30196"), "New York", "USA", new DateTime(2024, 4, 24, 15, 23, 58, 981, DateTimeKind.Local).AddTicks(5601), null, "john.doe@example.com", "John", "Doe", "123456789", null, null }
                });
        }
    }
}
