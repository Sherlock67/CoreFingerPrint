using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FingerPrintSolution.Migrations
{
    public partial class js : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JSMethodName",
                table: "Fingerprints",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "JSParameter",
                table: "Fingerprints",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JSMethodName",
                table: "Fingerprints");

            migrationBuilder.DropColumn(
                name: "JSParameter",
                table: "Fingerprints");
        }
    }
}
