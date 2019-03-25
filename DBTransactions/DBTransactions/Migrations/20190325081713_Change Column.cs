using Microsoft.EntityFrameworkCore.Migrations;

namespace DBTransactions.Migrations
{
    public partial class ChangeColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "MobNumber",
                table: "Students",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MobNumber",
                table: "Students",
                nullable: true,
                oldClrType: typeof(long));
        }
    }
}
