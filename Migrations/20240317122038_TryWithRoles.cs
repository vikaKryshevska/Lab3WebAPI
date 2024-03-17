using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lab3WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class TryWithRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "6964d251-5d26-4df4-9d6e-c5b15f14449e");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "799cb7f6-ef67-4170-87d2-02ea82179b4a");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c349a350-26d7-4f97-b932-8c2c5f116292");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e88a1e74-ce84-477f-9d3a-c8b96d17a686");

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Subscribers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Subscribers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Subscribers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Subscribers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Subscribers",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Subscribers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Subscribers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Subscribers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Subscribers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Subscribers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Subscribers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Subscribers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Subscribers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Administrators",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Administrators",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Administrators",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Administrators",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Administrators",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Administrators",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Administrators",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Administrators",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Administrators",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Administrators",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Administrators",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Administrators",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Administrators",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4dba704f-959f-4d22-b851-ac21fab096e7", null, "Administrator", "ADMINISTRATOR" },
                    { "81196f07-4960-4eb0-b5ea-e36e6c5e39e8", null, "Subscriber", "SUBSCRIBER" },
                    { "f1ffc3fe-b39c-4f05-a574-f95bc7cd0933", null, "Administrator", "ADMINISTRATOR" },
                    { "fedd5f0e-9982-4655-b86f-24ed381cc9a2", null, "Subscriber", "SUBSCRIBER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "4dba704f-959f-4d22-b851-ac21fab096e7");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "81196f07-4960-4eb0-b5ea-e36e6c5e39e8");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f1ffc3fe-b39c-4f05-a574-f95bc7cd0933");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "fedd5f0e-9982-4655-b86f-24ed381cc9a2");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Administrators");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Administrators");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Administrators");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Administrators");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Administrators");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Administrators");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Administrators");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Administrators");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Administrators");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Administrators");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Administrators");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Administrators");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Administrators");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6964d251-5d26-4df4-9d6e-c5b15f14449e", null, "Administrator", "ADMINISTRATOR" },
                    { "799cb7f6-ef67-4170-87d2-02ea82179b4a", null, "Subscriber", "SUBSCRIBER" },
                    { "c349a350-26d7-4f97-b932-8c2c5f116292", null, "Subscriber", "SUBSCRIBER" },
                    { "e88a1e74-ce84-477f-9d3a-c8b96d17a686", null, "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
