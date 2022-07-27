using Microsoft.EntityFrameworkCore.Migrations;

namespace BAI_1_5_EFCORE_CodeFirst.Migrations
{
    public partial class CreateDB2707221045 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Msv",
                table: "SinhVien",
                type: "int",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Msv",
                table: "SinhVien",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 200,
                oldNullable: true);
        }
    }
}
