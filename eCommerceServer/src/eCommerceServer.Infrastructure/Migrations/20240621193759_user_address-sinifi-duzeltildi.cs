using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCommerceServer.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class user_addresssinifiduzeltildi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AppUserId",
                table: "UserAddresses",
                type: "uniqueidentifier",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAddresses_Users_AppUserId",
                table: "UserAddresses");

            migrationBuilder.DropIndex(
                name: "IX_UserAddresses_AppUserId",
                table: "UserAddresses");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "UserAddresses");
        }
    }
}
