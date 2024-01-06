using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BiblioApp.Migrations
{
    public partial class genreA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "genre",
                table: "Adherent",
                type: "varchar(255)",
                nullable: true);  // or nullable: false, depending on your requirements
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "genre",
                table: "Adherent");
        }
    }
}
