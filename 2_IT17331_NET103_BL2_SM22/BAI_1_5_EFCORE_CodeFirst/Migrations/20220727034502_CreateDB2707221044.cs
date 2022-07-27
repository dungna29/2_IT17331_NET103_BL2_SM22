using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BAI_1_5_EFCORE_CodeFirst.Migrations
{
    public partial class CreateDB2707221044 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Point",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MonHoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdSv = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Point", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Point_SinhVien_IdSv",
                        column: x => x.IdSv,
                        principalTable: "SinhVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Point_IdSv",
                table: "Point",
                column: "IdSv");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Point");
        }
    }
}
