using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mango.Services.Product.API.Migrations
{
    public partial class SeedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Appetizer", "asvawgawg  awgawvagva awgawvagva awgawvagvaawgawvagva awgawvagva vawgawvagva awgawvagva awgawvagva awgawvagva awgawvagva awgawvagva awgawvagvaawgawvagva awgawvagvaawgawvagva", "https://gabimango.blob.core.windows.net/mango/14.jpg", "Samos", 15.0 },
                    { 2, "Appetizer", "asvawgawg  awgawvagva awgawvagva awgawvagvaawgawvagva awgawvagva vawgawvagva awgawvagva awgawvagva awgawvagva awgawvagva awgawvagva awgawvagvaawgawvagva awgawvagvaawgawvagva", "https://gabimango.blob.core.windows.net/mango/12.jpg", "Paneer Tikka", 16.0 },
                    { 3, "Desert", "asvawgawg  awgawvagva awgawvagva awgawvagvaawgawvagva awgawvagva vawgawvagva awgawvagva awgawvagva awgawvagva awgawvagva awgawvagva awgawvagvaawgawvagva awgawvagvaawgawvagva", "https://gabimango.blob.core.windows.net/mango/11.jpg", "Sweet Pie", 17.0 },
                    { 4, "Entree", "asvawgawg  awgawvagva awgawvagva awgawvagvaawgawvagva awgawvagva vawgawvagva awgawvagva awgawvagva awgawvagva awgawvagva awgawvagva awgawvagvaawgawvagva awgawvagvaawgawvagva", "https://gabimango.blob.core.windows.net/mango/13.jpg", "Pav Bhaji", 20.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
