using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class PointFieldsRenamed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Longitude",
                table: "Point",
                newName: "Lon");

            migrationBuilder.RenameColumn(
                name: "Latitude",
                table: "Point",
                newName: "Lat");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Lon",
                table: "Point",
                newName: "Longitude");

            migrationBuilder.RenameColumn(
                name: "Lat",
                table: "Point",
                newName: "Latitude");
        }
    }
}
