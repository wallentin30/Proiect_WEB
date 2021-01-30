using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect_WEB.Migrations
{
    public partial class Status : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StatusID",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusAngajat = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_StatusID",
                table: "Employee",
                column: "StatusID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Status_StatusID",
                table: "Employee",
                column: "StatusID",
                principalTable: "Status",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Status_StatusID",
                table: "Employee");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropIndex(
                name: "IX_Employee_StatusID",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "StatusID",
                table: "Employee");
        }
    }
}
