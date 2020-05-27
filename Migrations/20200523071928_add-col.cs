using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace uit_project_framework.Migrations
{
    public partial class addcol : Migration
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
                name: "IdOrder",
                table: "Orders",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "CreatedAt", "Description", "Image", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "the loai 1", null, "mo ta 1", "https://cdn.pixabay.com/photo/2016/11/09/16/24/virus-1812092__340.jpg", null },
                    { 2, "the loai 2", null, "mo ta 2", "https://cdn.pixabay.com/photo/2016/11/15/07/09/photo-manipulation-1825450__340.jpg", null },
                    { 3, "the loai 3", null, "mo ta 3", "https://cdn.pixabay.com/photo/2015/10/21/16/44/cold-999972__340.jpg", null }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Content", "CreatedAt", "Image", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "The key value is required so it must be supplied. When a migration is created, the SQL Server provider will enable the insertion of Identity values:", null, "https://cdn.pixabay.com/photo/2016/11/09/16/24/virus-1812092__340.jpg", "BAI VIET 1", null },
                    { 2, "This site can’t be reached", null, "https://cdn.pixabay.com/photo/2016/11/15/07/09/photo-manipulation-1825450__340.jpg", "BAI VIET 2", null },
                    { 3, "This site can’t be reached", null, "https://cdn.pixabay.com/photo/2016/11/15/07/09/photo-manipulation-1825450__340.jpg", "BAI VIET 3", null },
                    { 4, "This site can’t be reached", null, "https://cdn.pixabay.com/photo/2016/11/15/07/09/photo-manipulation-1825450__340.jpg", "BAI VIET 4", null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryID", "CreatedAt", "Image", "Price", "ProductName", "Unit", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://cdn.pixabay.com/photo/2016/11/09/16/24/virus-1812092__340.jpg", 2223m, "san pham 1", "cai", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://cdn.pixabay.com/photo/2015/10/21/16/44/cold-999972__340.jpg", 2223m, "san pham 2", "cai", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://cdn.pixabay.com/photo/2016/11/09/16/24/virus-1812092__340.jpg", 666m, "san pham 3", "mieng", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://cdn.pixabay.com/photo/2015/10/21/16/44/cold-999972__340.jpg", 111m, "san pham 4", "cuc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "IdOrder",
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
