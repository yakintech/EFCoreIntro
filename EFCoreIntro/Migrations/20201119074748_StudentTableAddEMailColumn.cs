using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreIntro.Migrations
{
    public partial class StudentTableAddEMailColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EMail",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EMail",
                table: "Students");
        }
    }
}
