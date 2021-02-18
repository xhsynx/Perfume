using Microsoft.EntityFrameworkCore.Migrations;

namespace Perfume.Migrations
{
    public partial class descriptionadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Perfumes",
                maxLength: 512,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Perfumes");
        }
    }
}
