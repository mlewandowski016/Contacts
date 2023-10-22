using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Contacts.Data.Migrations
{
    public partial class SeedCategoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "id", "category" },
                values: new object[,]
                {
                    { 1, "business" },
                    { 2, "private" },
                    { 3, "other" }
                });

            migrationBuilder.InsertData(
                table: "Subcategory",
                columns: new[] { "id", "subcategory" },
                values: new object[,]
                {
                    { 1, "boss" },
                    { 2, "coworker" },
                    { 3, "client" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
