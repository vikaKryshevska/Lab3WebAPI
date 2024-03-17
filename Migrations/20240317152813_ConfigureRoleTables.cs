using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lab3WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class ConfigureRoleTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Administrators_IdentityUser_IdentityRoleId",
                table: "Administrators");

            migrationBuilder.DropForeignKey(
                name: "FK_Bills_Subscribers_SubscriberId",
                table: "Bills");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceSubscriber_Subscribers_Subscribersid",
                table: "ServiceSubscriber");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscribers_IdentityUser_IdentityRoleId",
                table: "Subscribers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subscribers",
                table: "Subscribers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Administrators",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_IdentityUserRole<SUBSCRIBER>_SubscriberId",
                table: "Bills",
                column: "SubscriberId",
                principalTable: "IdentityUserRole<SUBSCRIBER>",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bills_IdentityUserRole<SUBSCRIBER>_SubscriberId",
                table: "Bills");

            migrationBuilder.DropForeignKey(
                name: "FK_IdentityUserRole<ADMIN>_IdentityUser_IdentityRoleId",
                table: "IdentityUserRole<ADMIN>");

            migrationBuilder.DropForeignKey(
                name: "FK_IdentityUserRole<SUBSCRIBER>_IdentityUser_IdentityRoleId",
                table: "IdentityUserRole<SUBSCRIBER>");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceSubscriber_IdentityUserRole<SUBSCRIBER>_Subscribersid",
                table: "ServiceSubscriber");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subscribers",
                table: "Subscribers",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Administrators",
                table: "Administrators",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Administrators_IdentityUser_IdentityRoleId",
                table: "Administrators",
                column: "IdentityRoleId",
                principalTable: "IdentityUser",
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
                name: "FK_Subscribers_IdentityUser_IdentityRoleId",
                table: "Subscribers",
                column: "IdentityRoleId",
                principalTable: "IdentityUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
