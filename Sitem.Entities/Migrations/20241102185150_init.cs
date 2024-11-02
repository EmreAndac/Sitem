using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sitem.Entities.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Metin = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    In = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Git = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Twitter = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Facebook = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Awards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Odul = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Awards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Okul = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Bolum = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Tarih = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Metin = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Bolum = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Metin = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DateBtw = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Interests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Metin = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkFlow = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Abouts_Id",
                table: "Abouts",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Awards_Id",
                table: "Awards",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_Id",
                table: "Educations",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_Id",
                table: "Experiences",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Interests_Id",
                table: "Interests",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_Id",
                table: "Skills",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Awards");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "Interests");

            migrationBuilder.DropTable(
                name: "Skills");
        }
    }
}
