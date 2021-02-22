using Microsoft.EntityFrameworkCore.Migrations;

namespace Datalink.Migrations
{
    public partial class Test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tree",
                table: "Tree");

            migrationBuilder.RenameTable(
                name: "Tree",
                newName: "Trees");

            migrationBuilder.AddColumn<int>(
                name: "ForestID",
                table: "Trees",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trees",
                table: "Trees",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "Forest",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ForestName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Biome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forest", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Trees_ForestID",
                table: "Trees",
                column: "ForestID");

            migrationBuilder.AddForeignKey(
                name: "FK_Trees_Forest_ForestID",
                table: "Trees",
                column: "ForestID",
                principalTable: "Forest",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trees_Forest_ForestID",
                table: "Trees");

            migrationBuilder.DropTable(
                name: "Forest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trees",
                table: "Trees");

            migrationBuilder.DropIndex(
                name: "IX_Trees_ForestID",
                table: "Trees");

            migrationBuilder.DropColumn(
                name: "ForestID",
                table: "Trees");

            migrationBuilder.RenameTable(
                name: "Trees",
                newName: "Tree");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tree",
                table: "Tree",
                column: "ID");
        }
    }
}
