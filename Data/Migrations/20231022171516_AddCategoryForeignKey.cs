using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Contacts.Data.Migrations
{
    public partial class AddCategoryForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "category",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "subcategory",
                table: "Contact");

            migrationBuilder.AddColumn<int>(
                name: "categoryid",
                table: "Contact",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "subcategoryid",
                table: "Contact",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Contact_categoryid",
                table: "Contact",
                column: "categoryid");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_subcategoryid",
                table: "Contact",
                column: "subcategoryid");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Category_categoryid",
                table: "Contact",
                column: "categoryid",
                principalTable: "Category",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Subcategory_subcategoryid",
                table: "Contact",
                column: "subcategoryid",
                principalTable: "Subcategory",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddColumn<int>(
                name: "categoryid",
                table: "Subcategory",
                type: "int",
                nullable: false,
                defaultValue: 0);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Category_categoryid",
                table: "Contact");

            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Subcategory_subcategoryid",
                table: "Contact");

            migrationBuilder.DropIndex(
                name: "IX_Contact_categoryid",
                table: "Contact");

            migrationBuilder.DropIndex(
                name: "IX_Contact_subcategoryid",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "categoryid",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "subcategoryid",
                table: "Contact");

            migrationBuilder.AddColumn<string>(
                name: "category",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "subcategory",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.DropColumn(
                name: "categoryid",
                table: "Subcategory");
        }
    }
}
