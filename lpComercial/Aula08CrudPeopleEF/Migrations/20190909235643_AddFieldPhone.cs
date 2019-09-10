using Microsoft.EntityFrameworkCore.Migrations;

namespace Aula08CrudPeopleEF.Migrations
{
    public partial class AddFieldPhone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "phone",
                table: "People",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "phone",
                table: "People");
        }
    }
}
