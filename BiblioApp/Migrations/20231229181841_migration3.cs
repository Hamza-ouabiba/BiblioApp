using Microsoft.EntityFrameworkCore.Migrations;

namespace BiblioApp.Migrations
{
    public partial class migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "Employe",
               columns: table => new
               {
                   idEmploye = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                   Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   Genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   isAdmin = table.Column<bool>(type: "bit", nullable: true),
                   nom = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK__Employe__97B32F2A5725FB37", x => x.idEmploye);
               });
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                 name: "Employe");
        }
    }
}
