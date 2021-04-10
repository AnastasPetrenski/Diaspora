using Microsoft.EntityFrameworkCore.Migrations;

namespace Diaspora.Data.Migrations
{
    public partial class MakeNavigationalPropertiesVirtual : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Node_NodeId1",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_NodeId1",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "NodeId1",
                table: "Players");

            migrationBuilder.AlterColumn<string>(
                name: "NodeId",
                table: "Players",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Players_NodeId",
                table: "Players",
                column: "NodeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Node_NodeId",
                table: "Players",
                column: "NodeId",
                principalTable: "Node",
                principalColumn: "NodeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Node_NodeId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_NodeId",
                table: "Players");

            migrationBuilder.AlterColumn<int>(
                name: "NodeId",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NodeId1",
                table: "Players",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Players_NodeId1",
                table: "Players",
                column: "NodeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Node_NodeId1",
                table: "Players",
                column: "NodeId1",
                principalTable: "Node",
                principalColumn: "NodeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
