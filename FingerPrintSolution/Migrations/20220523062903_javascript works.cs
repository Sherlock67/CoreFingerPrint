using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FingerPrintSolution.Migrations
{
    public partial class javascriptworks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JavaScriptToRun",
                table: "Fingerprints",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JavaScriptToRun",
                table: "Fingerprints");
        }
    }
}
