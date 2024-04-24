using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlowCRM.Migrations
{
    /// <inheritdoc />
    public partial class SocialSecurityNumberAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SocialSecurityNumber",
                table: "AspNetUsers",
                type: "nvarchar(12)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SocialSecurityNumber",
                table: "AspNetUsers");
        }
    }
}
