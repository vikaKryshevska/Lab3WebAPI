using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab3WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnToSubscriberTry2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Prise",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "SubscriberRef",
                table: "Subscribers");

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Prise = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bills_Subscribers_Id",
                        column: x => x.Id,
                        principalTable: "Subscribers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.AddColumn<double>(
                name: "Prise",
                table: "Subscribers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Subscribers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SubscriberRef",
                table: "Subscribers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
