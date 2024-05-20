using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FlowCRM.Migrations
{
    /// <inheritdoc />
    public partial class ActivityUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_ActivitiesType_FkActivityTypeId",
                table: "Activities");

            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Deals_FkDealId",
                table: "Activities");

            migrationBuilder.AlterColumn<Guid>(
                name: "FkDealId",
                table: "Activities",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "FkActivityTypeId",
                table: "Activities",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_ActivitiesType_FkActivityTypeId",
                table: "Activities",
                column: "FkActivityTypeId",
                principalTable: "ActivitiesType",
                principalColumn: "ActivityTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Deals_FkDealId",
                table: "Activities",
                column: "FkDealId",
                principalTable: "Deals",
                principalColumn: "DealId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_ActivitiesType_FkActivityTypeId",
                table: "Activities");

            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Deals_FkDealId",
                table: "Activities");

            migrationBuilder.AlterColumn<Guid>(
                name: "FkDealId",
                table: "Activities",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "FkActivityTypeId",
                table: "Activities",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_ActivitiesType_FkActivityTypeId",
                table: "Activities",
                column: "FkActivityTypeId",
                principalTable: "ActivitiesType",
                principalColumn: "ActivityTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Deals_FkDealId",
                table: "Activities",
                column: "FkDealId",
                principalTable: "Deals",
                principalColumn: "DealId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
