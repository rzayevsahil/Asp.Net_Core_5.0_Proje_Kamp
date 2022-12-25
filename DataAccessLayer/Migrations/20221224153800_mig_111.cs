using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_111 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cityn",
                table: "Cities");

            migrationBuilder.AddColumn<int>(
                name: "CityID",
                table: "Writers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Writers_CityID",
                table: "Writers",
                column: "CityID");

            migrationBuilder.AddForeignKey(
                name: "FK_Writers_Cities_CityID",
                table: "Writers",
                column: "CityID",
                principalTable: "Cities",
                principalColumn: "CityID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Writers_Cities_CityID",
                table: "Writers");

            migrationBuilder.DropIndex(
                name: "IX_Writers_CityID",
                table: "Writers");

            migrationBuilder.DropColumn(
                name: "CityID",
                table: "Writers");

            migrationBuilder.AddColumn<string>(
                name: "Cityn",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
