using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab3WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSubscriberAndService : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "password",
                table: "Administrators",
                newName: "Password");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Subscribers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Subscribers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Services",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Prise",
                table: "Services",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateIndex(
                name: "IX_Bills_SubscriberId",
                table: "Bills",
                column: "SubscriberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_Subscribers_SubscriberId",
                table: "Bills",
                column: "SubscriberId",
                principalTable: "Subscribers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bills_Subscribers_SubscriberId",
                table: "Bills");

            migrationBuilder.DropIndex(
                name: "IX_Bills_SubscriberId",
                table: "Bills");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "Prise",
                table: "Services");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Administrators",
                newName: "password");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Subscribers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Services",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
