using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class PolygonFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GraveUIPolygon_GraveItems_GraveId",
                table: "GraveUIPolygon");

            migrationBuilder.DropForeignKey(
                name: "FK_Point_GraveUIPolygon_GraveUIPolygonId",
                table: "Point");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GraveUIPolygon",
                table: "GraveUIPolygon");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "GraveUIPolygon");

            migrationBuilder.RenameTable(
                name: "GraveUIPolygon",
                newName: "GraveUIPolygons");

            migrationBuilder.RenameIndex(
                name: "IX_GraveUIPolygon_GraveId",
                table: "GraveUIPolygons",
                newName: "IX_GraveUIPolygons_GraveId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GraveUIPolygons",
                table: "GraveUIPolygons",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GraveUIPolygons_GraveItems_GraveId",
                table: "GraveUIPolygons",
                column: "GraveId",
                principalTable: "GraveItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Point_GraveUIPolygons_GraveUIPolygonId",
                table: "Point",
                column: "GraveUIPolygonId",
                principalTable: "GraveUIPolygons",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GraveUIPolygons_GraveItems_GraveId",
                table: "GraveUIPolygons");

            migrationBuilder.DropForeignKey(
                name: "FK_Point_GraveUIPolygons_GraveUIPolygonId",
                table: "Point");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GraveUIPolygons",
                table: "GraveUIPolygons");

            migrationBuilder.RenameTable(
                name: "GraveUIPolygons",
                newName: "GraveUIPolygon");

            migrationBuilder.RenameIndex(
                name: "IX_GraveUIPolygons_GraveId",
                table: "GraveUIPolygon",
                newName: "IX_GraveUIPolygon_GraveId");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "GraveUIPolygon",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GraveUIPolygon",
                table: "GraveUIPolygon",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GraveUIPolygon_GraveItems_GraveId",
                table: "GraveUIPolygon",
                column: "GraveId",
                principalTable: "GraveItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Point_GraveUIPolygon_GraveUIPolygonId",
                table: "Point",
                column: "GraveUIPolygonId",
                principalTable: "GraveUIPolygon",
                principalColumn: "Id");
        }
    }
}
