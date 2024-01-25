using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eHealth.Migrations
{
    /// <inheritdoc />
    public partial class addMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    inami = table.Column<string>(type: "TEXT", nullable: false),
                    firstName = table.Column<string>(type: "TEXT", nullable: false),
                    lastName = table.Column<string>(type: "TEXT", nullable: false),
                    birthDate = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    imageName = table.Column<string>(type: "TEXT", nullable: false),
                    imageFile = table.Column<byte[]>(type: "BLOB", nullable: true),
                    imageMimeType = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "id", "birthDate", "firstName", "imageFile", "imageMimeType", "imageName", "inami", "lastName" },
                values: new object[,]
                {
                    { 1, new DateOnly(2024, 1, 25), "Shawna", null, "image/jpeg", "shawna_trejo.jpg", "7055", "Trejo" },
                    { 2, new DateOnly(2024, 1, 25), "Rod", null, "image/jpeg", "rod_hale.jpg", "4478", "Hale" },
                    { 3, new DateOnly(2024, 1, 25), "Christopher", null, "image/jpeg", "christopher_green.jpg", "588", "Green" },
                    { 4, new DateOnly(2024, 1, 25), "Debra", null, "image/jpeg", "debra_meyer.jpg", "9077", "Meyers" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctors");
        }
    }
}
