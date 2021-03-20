using Microsoft.EntityFrameworkCore.Migrations;

namespace Softplan.Domain.Migrations
{
    public partial class StartDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countrys",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Area = table.Column<double>(type: "float", nullable: true),
                    Population = table.Column<double>(type: "float", nullable: true),
                    Capital = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countrys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OfficialLanguages",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Iso639_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Iso639_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NativeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficialLanguages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OfficialLanguages_Countrys_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countrys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OfficialLanguages_CountryId",
                table: "OfficialLanguages",
                column: "CountryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OfficialLanguages");

            migrationBuilder.DropTable(
                name: "Countrys");
        }
    }
}
