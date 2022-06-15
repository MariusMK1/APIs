using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PointsAPI.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PointId",
                table: "PointsLists");

            migrationBuilder.RenameColumn(
                name: "PointListId",
                table: "Point",
                newName: "PointsListId");

            migrationBuilder.CreateIndex(
                name: "IX_Point_PointsListId",
                table: "Point",
                column: "PointsListId");

            migrationBuilder.AddForeignKey(
                name: "FK_Point_PointsLists_PointsListId",
                table: "Point",
                column: "PointsListId",
                principalTable: "PointsLists",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Point_PointsLists_PointsListId",
                table: "Point");

            migrationBuilder.DropIndex(
                name: "IX_Point_PointsListId",
                table: "Point");

            migrationBuilder.RenameColumn(
                name: "PointsListId",
                table: "Point",
                newName: "PointListId");

            migrationBuilder.AddColumn<int>(
                name: "PointId",
                table: "PointsLists",
                type: "int",
                nullable: true);
        }
    }
}
