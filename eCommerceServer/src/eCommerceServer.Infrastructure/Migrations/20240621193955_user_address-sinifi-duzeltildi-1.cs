using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCommerceServer.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class user_addresssinifiduzeltildi1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAddresses_Users_AppUserId",
                table: "UserAddresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserAddresses",
                table: "UserAddresses");

            migrationBuilder.DropIndex(
                name: "IX_UserAddresses_AppUserId",
                table: "UserAddresses");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserAddresses");

            migrationBuilder.AlterColumn<Guid>(
                name: "AppUserId",
                table: "UserAddresses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserAddresses",
                table: "UserAddresses",
                columns: new[] { "AppUserId", "AddressId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserAddresses_Users_AppUserId",
                table: "UserAddresses",
                column: "AppUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAddresses_Users_AppUserId",
                table: "UserAddresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserAddresses",
                table: "UserAddresses");

            migrationBuilder.AlterColumn<Guid>(
                name: "AppUserId",
                table: "UserAddresses",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "UserAddresses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserAddresses",
                table: "UserAddresses",
                columns: new[] { "UserId", "AddressId" });

            migrationBuilder.CreateIndex(
                name: "IX_UserAddresses_AppUserId",
                table: "UserAddresses",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAddresses_Users_AppUserId",
                table: "UserAddresses",
                column: "AppUserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
