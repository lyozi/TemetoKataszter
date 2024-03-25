using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Point_GraveUIPolygons_GraveUIPolygonId",
                table: "Point");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Point",
                table: "Point");

            migrationBuilder.RenameTable(
                name: "Point",
                newName: "Points");

            migrationBuilder.RenameIndex(
                name: "IX_Point_GraveUIPolygonId",
                table: "Points",
                newName: "IX_Points_GraveUIPolygonId");

            migrationBuilder.AlterColumn<long>(
                name: "GraveUIPolygonId",
                table: "Points",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Points",
                table: "Points",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Points_GraveUIPolygons_GraveUIPolygonId",
                table: "Points",
                column: "GraveUIPolygonId",
                principalTable: "GraveUIPolygons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Points_GraveUIPolygons_GraveUIPolygonId",
                table: "Points");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Points",
                table: "Points");

            migrationBuilder.RenameTable(
                name: "Points",
                newName: "Point");

            migrationBuilder.RenameIndex(
                name: "IX_Points_GraveUIPolygonId",
                table: "Point",
                newName: "IX_Point_GraveUIPolygonId");

            migrationBuilder.AlterColumn<long>(
                name: "GraveUIPolygonId",
                table: "Point",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Point",
                table: "Point",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Point_GraveUIPolygons_GraveUIPolygonId",
                table: "Point",
                column: "GraveUIPolygonId",
                principalTable: "GraveUIPolygons",
                principalColumn: "Id");
        }
    }
}
