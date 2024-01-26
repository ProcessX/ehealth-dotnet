using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eHealth.Migrations.Patient
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FullName = table.Column<string>(type: "TEXT", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    BirthDate = table.Column<string>(type: "TEXT", nullable: false),
                    Gender = table.Column<string>(type: "TEXT", nullable: false),
                    Contact = table.Column<string>(type: "TEXT", nullable: false),
                    InsuranceNumber = table.Column<string>(type: "TEXT", nullable: false),
                    ChronicConditions = table.Column<string>(type: "TEXT", nullable: false),
                    PastMedicalHistory = table.Column<string>(type: "TEXT", nullable: false),
                    Medications = table.Column<string>(type: "TEXT", nullable: false),
                    FamilyMedicalHistory = table.Column<string>(type: "TEXT", nullable: false),
                    SocialHistory = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "id", "Age", "BirthDate", "ChronicConditions", "Contact", "Description", "FamilyMedicalHistory", "FullName", "Gender", "InsuranceNumber", "Medications", "PastMedicalHistory", "SocialHistory" },
                values: new object[,]
                {
                    { 1, 324, "13/07/1994", "Chronic Conditions text details pour mon patiet est = bla bla bla bla bla ...", "0484666560", "Description 01", "Family Medical History text details pour mon patiet est = bla bla bla bla bla ...", "Erling Haland", "Homme", "NI-8956", "Medications text details pour mon patiet est = bla bla bla bla bla ...", "Past Medical History text details pour mon patiet est = bla bla bla bla bla ...", "Marié" },
                    { 2, 326, "13/07/1994", "Chronic Conditions text details pour mon patiet est = bla bla bla bla bla ...", "0484666560", "Description 02", "Family Medical History text details pour mon patiet est = bla bla bla bla bla ...", "Kilian Empapé", "Homme", "NI-8956", "Medications text details pour mon patiet est = bla bla bla bla bla ...", "Past Medical History text details pour mon patiet est = bla bla bla bla bla ...", "Marié" },
                    { 3, 34, "13/07/1994", "Chronic Conditions text details pour mon patiet est = bla bla bla bla bla ...", "0484666560", "Description 03", "Family Medical History text details pour mon patiet est = bla bla bla bla bla ...", "Lionel Messi", "Homme", "NI-8956", "Medications text details pour mon patiet est = bla bla bla bla bla ...", "Past Medical History text details pour mon patiet est = bla bla bla bla bla ...", "Marié" },
                    { 4, 38, "13/07/1994", "Chronic Conditions text details pour mon patiet est = bla bla bla bla bla ...", "0484666560", "Description 04", "Family Medical History text details pour mon patiet est = bla bla bla bla bla ...", "Cristiano Renaldo", "Homme", "NI-8956", "Medications text details pour mon patiet est = bla bla bla bla bla ...", "Past Medical History text details pour mon patiet est = bla bla bla bla bla ...", "Marié" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
