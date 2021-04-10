using Microsoft.EntityFrameworkCore.Migrations;

namespace Diaspora.Data.Migrations
{
    public partial class PickPropertyPlansTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Pick",
                table: "Plans",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pick",
                table: "Plans");
        }
    }
}
