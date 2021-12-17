using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectAPI.Migrations
{
    public partial class TaBortFKfrånLogEntry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LogEntries_Codes_CodeId",
                table: "LogEntries");

            migrationBuilder.DropForeignKey(
                name: "FK_LogEntries_Doors_DoorId",
                table: "LogEntries");

            migrationBuilder.DropForeignKey(
                name: "FK_LogEntries_Tags_TagId",
                table: "LogEntries");

            migrationBuilder.DropIndex(
                name: "IX_LogEntries_CodeId",
                table: "LogEntries");

            migrationBuilder.DropIndex(
                name: "IX_LogEntries_DoorId",
                table: "LogEntries");

            migrationBuilder.DropIndex(
                name: "IX_LogEntries_TagId",
                table: "LogEntries");

            migrationBuilder.DropColumn(
                name: "CodeId",
                table: "LogEntries");

            migrationBuilder.DropColumn(
                name: "DoorId",
                table: "LogEntries");

            migrationBuilder.DropColumn(
                name: "TagId",
                table: "LogEntries");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CodeId",
                table: "LogEntries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DoorId",
                table: "LogEntries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TagId",
                table: "LogEntries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_LogEntries_CodeId",
                table: "LogEntries",
                column: "CodeId");

            migrationBuilder.CreateIndex(
                name: "IX_LogEntries_DoorId",
                table: "LogEntries",
                column: "DoorId");

            migrationBuilder.CreateIndex(
                name: "IX_LogEntries_TagId",
                table: "LogEntries",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_LogEntries_Codes_CodeId",
                table: "LogEntries",
                column: "CodeId",
                principalTable: "Codes",
                principalColumn: "CodeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LogEntries_Doors_DoorId",
                table: "LogEntries",
                column: "DoorId",
                principalTable: "Doors",
                principalColumn: "DoorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LogEntries_Tags_TagId",
                table: "LogEntries",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "TagId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
