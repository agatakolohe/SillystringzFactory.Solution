using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class AddEngineerStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EngineerStatus",
                table: "Engineers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EngineerStatus",
                table: "Engineers");
        }
    }
}
