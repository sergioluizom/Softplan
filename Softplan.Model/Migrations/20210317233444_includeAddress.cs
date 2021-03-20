using Microsoft.EntityFrameworkCore.Migrations;

namespace Softplan.Domain.Migrations
{
    public partial class includeAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Countrys",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Version",
                table: "Countrys",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Countrys");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "Countrys");
        }
    }
}
