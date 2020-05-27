using Microsoft.EntityFrameworkCore.Migrations;

namespace uit_project_framework.Migrations
{
    public partial class acbbb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdOrder",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "idOrder",
                table: "Orders",
                newName: "IdOrder");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdOrder",
                table: "Orders",
                newName: "idOrder");

            migrationBuilder.AddColumn<string>(
                name: "IdOrder",
                table: "Orders",
                nullable: true);
        }
    }
}
