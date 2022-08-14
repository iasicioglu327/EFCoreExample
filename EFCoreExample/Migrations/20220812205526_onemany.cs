using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreExample.Migrations
{
    public partial class onemany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Citys_CityID",
                table: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_Countries_CityID",
                table: "Countries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Citys",
                table: "Citys");

            migrationBuilder.DropColumn(
                name: "CityID",
                table: "Countries");

            migrationBuilder.RenameTable(
                name: "Citys",
                newName: "Cities");

            migrationBuilder.AddColumn<int>(
                name: "CountryID",
                table: "Cities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cities",
                table: "Cities",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryID",
                table: "Cities",
                column: "CountryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Countries_CountryID",
                table: "Cities",
                column: "CountryID",
                principalTable: "Countries",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Countries_CountryID",
                table: "Cities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cities",
                table: "Cities");

            migrationBuilder.DropIndex(
                name: "IX_Cities_CountryID",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "CountryID",
                table: "Cities");

            migrationBuilder.RenameTable(
                name: "Cities",
                newName: "Citys");

            migrationBuilder.AddColumn<int>(
                name: "CityID",
                table: "Countries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Citys",
                table: "Citys",
                column: "ID");

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
    }
}
