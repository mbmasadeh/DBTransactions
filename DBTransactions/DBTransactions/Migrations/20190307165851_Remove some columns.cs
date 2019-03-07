using Microsoft.EntityFrameworkCore.Migrations;

namespace DBTransactions.Migrations
{
    public partial class Removesomecolumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_Students_SttudentsID",
                table: "StudentCourse");

            migrationBuilder.RenameColumn(
                name: "SttudentsID",
                table: "StudentCourse",
                newName: "StudentsID");

            migrationBuilder.RenameIndex(
                name: "IX_StudentCourse_SttudentsID",
                table: "StudentCourse",
                newName: "IX_StudentCourse_StudentsID");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_Students_StudentsID",
                table: "StudentCourse",
                column: "StudentsID",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_Students_StudentsID",
                table: "StudentCourse");

            migrationBuilder.RenameColumn(
                name: "StudentsID",
                table: "StudentCourse",
                newName: "SttudentsID");

            migrationBuilder.RenameIndex(
                name: "IX_StudentCourse_StudentsID",
                table: "StudentCourse",
                newName: "IX_StudentCourse_SttudentsID");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_Students_SttudentsID",
                table: "StudentCourse",
                column: "SttudentsID",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
