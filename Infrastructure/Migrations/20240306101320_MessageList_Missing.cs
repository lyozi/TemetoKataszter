using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MessageList_Missing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Message_DeceasedItems_DeceasedId",
                table: "Message");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Message",
                table: "Message");

            migrationBuilder.RenameTable(
                name: "Message",
                newName: "MessageItems");

            migrationBuilder.RenameIndex(
                name: "IX_Message_DeceasedId",
                table: "MessageItems",
                newName: "IX_MessageItems_DeceasedId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MessageItems",
                table: "MessageItems",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MessageItems_DeceasedItems_DeceasedId",
                table: "MessageItems",
                column: "DeceasedId",
                principalTable: "DeceasedItems",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MessageItems_DeceasedItems_DeceasedId",
                table: "MessageItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MessageItems",
                table: "MessageItems");

            migrationBuilder.RenameTable(
                name: "MessageItems",
                newName: "Message");

            migrationBuilder.RenameIndex(
                name: "IX_MessageItems_DeceasedId",
                table: "Message",
                newName: "IX_Message_DeceasedId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Message",
                table: "Message",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Message_DeceasedItems_DeceasedId",
                table: "Message",
                column: "DeceasedId",
                principalTable: "DeceasedItems",
                principalColumn: "Id");
        }
    }
}
