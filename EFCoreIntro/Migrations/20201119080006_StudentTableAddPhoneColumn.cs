using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreIntro.Migrations
{
    public partial class StudentTableAddPhoneColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Students");
        }
    }
}
