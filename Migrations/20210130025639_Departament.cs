using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect_WEB.Migrations
{
    public partial class Departament : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartamentID",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Departament",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeDepartament = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departament", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DepartamentID",
                table: "Employee",
                column: "DepartamentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Departament_DepartamentID",
                table: "Employee",
                column: "DepartamentID",
                principalTable: "Departament",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Departament_DepartamentID",
                table: "Employee");

            migrationBuilder.DropTable(
                name: "Departament");

            migrationBuilder.DropIndex(
                name: "IX_Employee_DepartamentID",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "DepartamentID",
                table: "Employee");
        }
    }
}
