using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreCLI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HocPhan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocPhan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SinhVien",
                columns: table => new
                {
                    MSSV = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Gender = table.Column<bool>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Birthday = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinhVien", x => x.MSSV);
                });

            migrationBuilder.CreateTable(
                name: "LopHocPhan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdHocPhan = table.Column<int>(nullable: false),
                    MSSV = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LopHocPhan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LopHocPhan_HocPhan_IdHocPhan",
                        column: x => x.IdHocPhan,
                        principalTable: "HocPhan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LopHocPhan_SinhVien_MSSV",
                        column: x => x.MSSV,
                        principalTable: "SinhVien",
                        principalColumn: "MSSV",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LopHocPhan_IdHocPhan",
                table: "LopHocPhan",
                column: "IdHocPhan");

            migrationBuilder.CreateIndex(
                name: "IX_LopHocPhan_MSSV",
                table: "LopHocPhan",
                column: "MSSV");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LopHocPhan");

            migrationBuilder.DropTable(
                name: "HocPhan");

            migrationBuilder.DropTable(
                name: "SinhVien");
        }
    }
}
