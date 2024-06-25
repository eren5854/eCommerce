using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCommerceServer.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class appUserrefreshTokenemailConfirmforgotPasswordsutunlarieklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmailConfirmCode",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EmailConfirmCodeSendDate",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ForgotPasswordCode",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ForgotPasswordCodeSendDate",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpires",
                table: "Users",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailConfirmCode",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "EmailConfirmCodeSendDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ForgotPasswordCode",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ForgotPasswordCodeSendDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpires",
                table: "Users");
        }
    }
}
