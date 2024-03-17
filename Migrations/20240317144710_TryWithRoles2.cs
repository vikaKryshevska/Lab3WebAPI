using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lab3WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class TryWithRoles2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceSubscriber_Subscribers_SubscribersId",
                table: "ServiceSubscriber");

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

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Subscribers",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "SubscribersId",
                table: "ServiceSubscriber",
                newName: "Subscribersid");

            migrationBuilder.RenameIndex(
                name: "IX_ServiceSubscriber_SubscribersId",
                table: "ServiceSubscriber",
                newName: "IX_ServiceSubscriber_Subscribersid");

            migrationBuilder.AddColumn<string>(
                name: "IdentityRoleId",
                table: "Subscribers",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IdentityRoleId",
                table: "Administrators",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "IdentityUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    IdentityRoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdentityRoleId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IdentityUser_IdentityRole_IdentityRoleId1",
                        column: x => x.IdentityRoleId1,
                        principalTable: "IdentityRole",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "00fae4e9-d9e6-4900-809e-9cc34e7eb5db", null, "Administrator", "ADMINISTRATOR" },
                    { "0b995cf2-f31a-4196-b063-c329a4dbff5b", null, "Administrator", "ADMINISTRATOR" },
                    { "6a410b6f-99ab-4422-85f3-7bcc3bffda91", null, "Subscriber", "SUBSCRIBER" },
                    { "d03d4e61-13e3-4da9-acd5-d90d89a9b7d2", null, "Subscriber", "SUBSCRIBER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Subscribers_IdentityRoleId",
                table: "Subscribers",
                column: "IdentityRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Administrators_IdentityRoleId",
                table: "Administrators",
                column: "IdentityRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_IdentityUser_IdentityRoleId1",
                table: "IdentityUser",
                column: "IdentityRoleId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Administrators_IdentityUser_IdentityRoleId",
                table: "Administrators",
                column: "IdentityRoleId",
                principalTable: "IdentityUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceSubscriber_Subscribers_Subscribersid",
                table: "ServiceSubscriber",
                column: "Subscribersid",
                principalTable: "Subscribers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscribers_IdentityUser_IdentityRoleId",
                table: "Subscribers",
                column: "IdentityRoleId",
                principalTable: "IdentityUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Administrators_IdentityUser_IdentityRoleId",
                table: "Administrators");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceSubscriber_Subscribers_Subscribersid",
                table: "ServiceSubscriber");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscribers_IdentityUser_IdentityRoleId",
                table: "Subscribers");

            migrationBuilder.DropTable(
                name: "IdentityUser");

            migrationBuilder.DropIndex(
                name: "IX_Subscribers_IdentityRoleId",
                table: "Subscribers");

            migrationBuilder.DropIndex(
                name: "IX_Administrators_IdentityRoleId",
                table: "Administrators");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "00fae4e9-d9e6-4900-809e-9cc34e7eb5db");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "0b995cf2-f31a-4196-b063-c329a4dbff5b");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "6a410b6f-99ab-4422-85f3-7bcc3bffda91");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d03d4e61-13e3-4da9-acd5-d90d89a9b7d2");

            migrationBuilder.DropColumn(
                name: "IdentityRoleId",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "IdentityRoleId",
                table: "Administrators");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Subscribers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Subscribersid",
                table: "ServiceSubscriber",
                newName: "SubscribersId");

            migrationBuilder.RenameIndex(
                name: "IX_ServiceSubscriber_Subscribersid",
                table: "ServiceSubscriber",
                newName: "IX_ServiceSubscriber_SubscribersId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceSubscriber_Subscribers_SubscribersId",
                table: "ServiceSubscriber",
                column: "SubscribersId",
                principalTable: "Subscribers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
