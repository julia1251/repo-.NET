using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FizzBuzz.Migrations
{
    public partial class InitSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Liczby",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    liczba = table.Column<int>(nullable: false),
                    Wynik = table.Column<string>(nullable: true),
                    DataWyszukania = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Liczby", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Liczby");
        }
    }
}
