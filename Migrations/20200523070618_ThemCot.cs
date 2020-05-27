using Microsoft.EntityFrameworkCore.Migrations;

namespace uit_project_framework.Migrations
{
    public partial class ThemCot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "ProductAmount",
                table: "Posts");

            migrationBuilder.AddColumn<string>(
                name: "idOrder",
                table: "Orders",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "idOrder",
                table: "Orders");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Posts",
                type: "varchar(250)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductAmount",
                table: "Posts",
                nullable: false,
                defaultValue: 0);
        }
    }
}
