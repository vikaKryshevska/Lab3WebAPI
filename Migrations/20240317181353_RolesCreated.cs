using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lab3WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class RolesCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bills_IdentityUserRole<SUBSCRIBER>_SubscriberId",
                table: "Bills");

            migrationBuilder.DropForeignKey(
                name: "FK_IdentityUser_IdentityRole_IdentityRoleId1",
                table: "IdentityUser");

            migrationBuilder.DropForeignKey(
                name: "FK_IdentityUserRole<ADMIN>_IdentityUser_IdentityRoleId",
                table: "IdentityUserRole<ADMIN>");

            migrationBuilder.DropForeignKey(
                name: "FK_IdentityUserRole<SUBSCRIBER>_IdentityUser_IdentityRoleId",
                table: "IdentityUserRole<SUBSCRIBER>");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceSubscriber_IdentityUserRole<SUBSCRIBER>_Subscribersid",
                table: "ServiceSubscriber");

            migrationBuilder.DropIndex(
                name: "IX_IdentityUser_IdentityRoleId1",
                table: "IdentityUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityUserRole<SUBSCRIBER>",
                table: "IdentityUserRole<SUBSCRIBER>");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityUserRole<ADMIN>",
                table: "IdentityUserRole<ADMIN>");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "57560414-c1f8-44c9-9116-4df705ea19b9");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "ac1d5add-6a97-4c2c-b951-a16178c355d9");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b6df8d18-e983-454a-8421-03c9ab1bd1d6");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "bc3f1c97-00b2-4fc0-83c3-5f0e893f2927");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "IdentityUser");

            migrationBuilder.DropColumn(
                name: "IdentityRoleId",
                table: "IdentityUser");

            migrationBuilder.DropColumn(
                name: "IdentityRoleId1",
                table: "IdentityUser");

            migrationBuilder.RenameTable(
                name: "IdentityUserRole<SUBSCRIBER>",
                newName: "Subscribers");

            migrationBuilder.RenameTable(
                name: "IdentityUserRole<ADMIN>",
                newName: "Administrators");

            migrationBuilder.RenameIndex(
                name: "IX_IdentityUserRole<SUBSCRIBER>_IdentityRoleId",
                table: "Subscribers",
                newName: "IX_Subscribers_IdentityRoleId");

            migrationBuilder.RenameIndex(
                name: "IX_IdentityUserRole<ADMIN>_IdentityRoleId",
                table: "Administrators",
                newName: "IX_Administrators_IdentityRoleId");

            migrationBuilder.AlterColumn<int>(
                name: "IdentityRoleId",
                table: "Subscribers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "IdentityRoleId",
                table: "Administrators",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subscribers",
                table: "Subscribers",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Administrators",
                table: "Administrators",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentityRoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_Account", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Account_IdentityRole_IdentityRoleId1",
                        column: x => x.IdentityRoleId1,
                        principalTable: "IdentityRole",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "IdentityUserRole<Guid>",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserRole<Guid>", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "614ab4a3-0269-4fe6-8e42-a7690ce6248e", null, "Administrator", "ADMINISTRATOR" },
                    { "820c523d-1c65-46c8-909b-13fdb497a81d", null, "Subscriber", "SUBSCRIBER" },
                    { "963b3755-421f-483e-8cb9-07443301b9af", null, "Administrator", "ADMINISTRATOR" },
                    { "b1395323-91da-4e46-98f8-981a4f91dd4f", null, "Subscriber", "SUBSCRIBER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Account_IdentityRoleId1",
                table: "Account",
                column: "IdentityRoleId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Administrators_Account_IdentityRoleId",
                table: "Administrators",
                column: "IdentityRoleId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_Subscribers_SubscriberId",
                table: "Bills",
                column: "SubscriberId",
                principalTable: "Subscribers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceSubscriber_Subscribers_Subscribersid",
                table: "ServiceSubscriber",
                column: "Subscribersid",
                principalTable: "Subscribers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscribers_Account_IdentityRoleId",
                table: "Subscribers",
                column: "IdentityRoleId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Administrators_Account_IdentityRoleId",
                table: "Administrators");

            migrationBuilder.DropForeignKey(
                name: "FK_Bills_Subscribers_SubscriberId",
                table: "Bills");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceSubscriber_Subscribers_Subscribersid",
                table: "ServiceSubscriber");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscribers_Account_IdentityRoleId",
                table: "Subscribers");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "IdentityUserRole<Guid>");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subscribers",
                table: "Subscribers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Administrators",
                table: "Administrators");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "614ab4a3-0269-4fe6-8e42-a7690ce6248e");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "820c523d-1c65-46c8-909b-13fdb497a81d");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "963b3755-421f-483e-8cb9-07443301b9af");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b1395323-91da-4e46-98f8-981a4f91dd4f");

            migrationBuilder.RenameTable(
                name: "Subscribers",
                newName: "IdentityUserRole<SUBSCRIBER>");

            migrationBuilder.RenameTable(
                name: "Administrators",
                newName: "IdentityUserRole<ADMIN>");

            migrationBuilder.RenameIndex(
                name: "IX_Subscribers_IdentityRoleId",
                table: "IdentityUserRole<SUBSCRIBER>",
                newName: "IX_IdentityUserRole<SUBSCRIBER>_IdentityRoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Administrators_IdentityRoleId",
                table: "IdentityUserRole<ADMIN>",
                newName: "IX_IdentityUserRole<ADMIN>_IdentityRoleId");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "IdentityUser",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "IdentityRoleId",
                table: "IdentityUser",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdentityRoleId1",
                table: "IdentityUser",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdentityRoleId",
                table: "IdentityUserRole<SUBSCRIBER>",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "IdentityRoleId",
                table: "IdentityUserRole<ADMIN>",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityUserRole<SUBSCRIBER>",
                table: "IdentityUserRole<SUBSCRIBER>",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityUserRole<ADMIN>",
                table: "IdentityUserRole<ADMIN>",
                column: "Id");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "57560414-c1f8-44c9-9116-4df705ea19b9", null, "Subscriber", "SUBSCRIBER" },
                    { "ac1d5add-6a97-4c2c-b951-a16178c355d9", null, "Administrator", "ADMINISTRATOR" },
                    { "b6df8d18-e983-454a-8421-03c9ab1bd1d6", null, "Subscriber", "SUBSCRIBER" },
                    { "bc3f1c97-00b2-4fc0-83c3-5f0e893f2927", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_IdentityUser_IdentityRoleId1",
                table: "IdentityUser",
                column: "IdentityRoleId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_IdentityUserRole<SUBSCRIBER>_SubscriberId",
                table: "Bills",
                column: "SubscriberId",
                principalTable: "IdentityUserRole<SUBSCRIBER>",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUser_IdentityRole_IdentityRoleId1",
                table: "IdentityUser",
                column: "IdentityRoleId1",
                principalTable: "IdentityRole",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserRole<ADMIN>_IdentityUser_IdentityRoleId",
                table: "IdentityUserRole<ADMIN>",
                column: "IdentityRoleId",
                principalTable: "IdentityUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserRole<SUBSCRIBER>_IdentityUser_IdentityRoleId",
                table: "IdentityUserRole<SUBSCRIBER>",
                column: "IdentityRoleId",
                principalTable: "IdentityUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceSubscriber_IdentityUserRole<SUBSCRIBER>_Subscribersid",
                table: "ServiceSubscriber",
                column: "Subscribersid",
                principalTable: "IdentityUserRole<SUBSCRIBER>",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
