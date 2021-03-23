using Microsoft.EntityFrameworkCore.Migrations;

namespace Softplan.Domain.Migrations
{
    public partial class include_svg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FlagId",
                table: "Countrys",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Flag",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SvgFile = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flag", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countrys_FlagId",
                table: "Countrys",
                column: "FlagId");

            migrationBuilder.AddForeignKey(
                name: "FK_Countrys_Flag_FlagId",
                table: "Countrys",
                column: "FlagId",
                principalTable: "Flag",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countrys_Flag_FlagId",
                table: "Countrys");

            migrationBuilder.DropTable(
                name: "Flag");

            migrationBuilder.DropIndex(
                name: "IX_Countrys_FlagId",
                table: "Countrys");

            migrationBuilder.DropColumn(
                name: "FlagId",
                table: "Countrys");
        }
    }
}
