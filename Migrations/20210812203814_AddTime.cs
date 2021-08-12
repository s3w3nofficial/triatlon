using Microsoft.EntityFrameworkCore.Migrations;

namespace triatlon.Migrations
{
    public partial class AddTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Time_Entries_EntryId",
                table: "Time");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Time",
                table: "Time");

            migrationBuilder.RenameTable(
                name: "Time",
                newName: "Times");

            migrationBuilder.RenameIndex(
                name: "IX_Time_EntryId",
                table: "Times",
                newName: "IX_Times_EntryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Times",
                table: "Times",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Times_Entries_EntryId",
                table: "Times",
                column: "EntryId",
                principalTable: "Entries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Times_Entries_EntryId",
                table: "Times");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Times",
                table: "Times");

            migrationBuilder.RenameTable(
                name: "Times",
                newName: "Time");

            migrationBuilder.RenameIndex(
                name: "IX_Times_EntryId",
                table: "Time",
                newName: "IX_Time_EntryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Time",
                table: "Time",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Time_Entries_EntryId",
                table: "Time",
                column: "EntryId",
                principalTable: "Entries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
