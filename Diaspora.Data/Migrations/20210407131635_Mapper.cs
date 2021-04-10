using Microsoft.EntityFrameworkCore.Migrations;

namespace Diaspora.Data.Migrations
{
    public partial class Mapper : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NodeId",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "NodeId1",
                table: "Players",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Node",
                columns: table => new
                {
                    NodeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pick = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoordinatePixels = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Node", x => x.NodeId);
                });

            migrationBuilder.CreateTable(
                name: "Mappers",
                columns: table => new
                {
                    EdgeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FromId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ToId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mappers", x => x.EdgeId);
                    table.ForeignKey(
                        name: "FK_Mappers_Node_FromId",
                        column: x => x.FromId,
                        principalTable: "Node",
                        principalColumn: "NodeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mappers_Node_ToId",
                        column: x => x.ToId,
                        principalTable: "Node",
                        principalColumn: "NodeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Players_NodeId1",
                table: "Players",
                column: "NodeId1");

            migrationBuilder.CreateIndex(
                name: "IX_Mappers_FromId",
                table: "Mappers",
                column: "FromId");

            migrationBuilder.CreateIndex(
                name: "IX_Mappers_ToId",
                table: "Mappers",
                column: "ToId");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Node_NodeId1",
                table: "Players",
                column: "NodeId1",
                principalTable: "Node",
                principalColumn: "NodeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Node_NodeId1",
                table: "Players");

            migrationBuilder.DropTable(
                name: "Mappers");

            migrationBuilder.DropTable(
                name: "Node");

            migrationBuilder.DropIndex(
                name: "IX_Players_NodeId1",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "NodeId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "NodeId1",
                table: "Players");
        }
    }
}
