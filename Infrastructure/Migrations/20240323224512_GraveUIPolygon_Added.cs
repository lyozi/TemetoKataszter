using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class GraveUIPolygon_Added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GraveUIPolygon",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    GraveId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GraveUIPolygon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GraveUIPolygon_GraveItems_GraveId",
                        column: x => x.GraveId,
                        principalTable: "GraveItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Point",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Latitude = table.Column<double>(type: "double precision", nullable: false),
                    Longitude = table.Column<double>(type: "double precision", nullable: false),
                    GraveUIPolygonId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Point", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Point_GraveUIPolygon_GraveUIPolygonId",
                        column: x => x.GraveUIPolygonId,
                        principalTable: "GraveUIPolygon",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_GraveUIPolygon_GraveId",
                table: "GraveUIPolygon",
                column: "GraveId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Point_GraveUIPolygonId",
                table: "Point",
                column: "GraveUIPolygonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Point");

            migrationBuilder.DropTable(
                name: "GraveUIPolygon");
        }
    }
}
