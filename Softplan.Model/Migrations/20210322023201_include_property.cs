using Microsoft.EntityFrameworkCore.Migrations;

namespace Softplan.Domain.Migrations
{
    public partial class include_property : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsApi",
                table: "Countrys",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsApi",
                table: "Countrys");
        }
    }
}
