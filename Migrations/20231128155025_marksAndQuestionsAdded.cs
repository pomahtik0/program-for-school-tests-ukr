using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace program_for_school_tests_ukr.Migrations
{
    /// <inheritdoc />
    public partial class marksAndQuestionsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mark_Tests_TestId",
                table: "Mark");

            migrationBuilder.DropForeignKey(
                name: "FK_Mark_Users_StudentId",
                table: "Mark");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mark",
                table: "Mark");

            migrationBuilder.RenameTable(
                name: "Mark",
                newName: "Marks");

            migrationBuilder.RenameIndex(
                name: "IX_Mark_TestId",
                table: "Marks",
                newName: "IX_Marks_TestId");

            migrationBuilder.RenameIndex(
                name: "IX_Mark_StudentId",
                table: "Marks",
                newName: "IX_Marks_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Marks",
                table: "Marks",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Marks_Tests_TestId",
                table: "Marks",
                column: "TestId",
                principalTable: "Tests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Marks_Users_StudentId",
                table: "Marks",
                column: "StudentId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Marks_Tests_TestId",
                table: "Marks");

            migrationBuilder.DropForeignKey(
                name: "FK_Marks_Users_StudentId",
                table: "Marks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Marks",
                table: "Marks");

            migrationBuilder.RenameTable(
                name: "Marks",
                newName: "Mark");

            migrationBuilder.RenameIndex(
                name: "IX_Marks_TestId",
                table: "Mark",
                newName: "IX_Mark_TestId");

            migrationBuilder.RenameIndex(
                name: "IX_Marks_StudentId",
                table: "Mark",
                newName: "IX_Mark_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mark",
                table: "Mark",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Mark_Tests_TestId",
                table: "Mark",
                column: "TestId",
                principalTable: "Tests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mark_Users_StudentId",
                table: "Mark",
                column: "StudentId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
