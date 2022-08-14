using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreExample.Migrations
{
    public partial class city : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityID",
                table: "Countries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountryPopulation",
                table: "Countries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Citys",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityPopulation = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citys", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CityID",
                table: "Countries",
                column: "CityID");

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Citys_CityID",
                table: "Countries",
                column: "CityID",
                principalTable: "Citys",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Citys_CityID",
                table: "Countries");

            migrationBuilder.DropTable(
                name: "Citys");

            migrationBuilder.DropIndex(
                name: "IX_Countries_CityID",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "CityID",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "CountryPopulation",
                table: "Countries");
        }
    }
}
