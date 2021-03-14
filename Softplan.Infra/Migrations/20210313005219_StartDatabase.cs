using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Softplan.Infra.Migrations
{
    public partial class StartDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countrys",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Area = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Population = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Capital = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countrys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OfficialLanguage",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Iso639_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Iso639_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NativeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficialLanguage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OfficialLanguage_Countrys_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countrys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OfficialLanguage_CountryId",
                table: "OfficialLanguage",
                column: "CountryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OfficialLanguage");

            migrationBuilder.DropTable(
                name: "Countrys");
        }
    }
}
