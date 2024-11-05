using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExoticIslands_api.Data.Migrations
{
    /// <inheritdoc />
    public partial class M1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Islands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Country = table.Column<string>(type: "TEXT", nullable: true),
                    Base64Image = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Islands", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Islands",
                columns: new[] { "Id", "Base64Image", "Country", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "", "French Polynesia", "Famous for its seaside luxury resorts, turquoise lagoons, and coral reefs.", "Bora Bora" },
                    { 2, "", "Maldives", "The maldives is a country that is filled with a series of 1,192 different exotic islands.", "Maldives" },
                    { 3, "", "French Polynesia", "Tahiti is the largest island in French Polunesia. It has a shape of a figure-8 when viewed from above.", "Tahiti" },
                    { 4, "", "Seychelles", "The seychelles is the smallest country in Africa and holds a number of 115 islands in the Indian Ocean.", "Seychelles" },
                    { 5, "", "Philippines", "Palawan is an archipelagic province located in the region of Mimaropa.", "Palawan" },
                    { 6, "", "Indonesia", "Bali is a province of Indonesia and the westernmost of the Lesser Sunda Islands.", "Bali" },
                    { 7, "", "United States", "Hawaii is an island state in the Pacific Ocean, the only US state in the tropics.", "Hawaii" },
                    { 8, "", "Saint Kitts and Nevis", "An island country consisting of the two islands of Saint Kitts and Nevis.", "Saint Kitts and Nevis" },
                    { 9, "", "Thailand", "Phi Phi Islands are an island group in Thailand between the large island of Phuket and Straits of Malacca coast of Thailand.", "Ko Phi Phi" },
                    { 10, "", "Ecuador", "The Galapagos Islands is a volcanic archipelago and also considered one of the world's foremost destinations for wildlife-viewing.", "Galapagos Islands" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Islands");
        }
    }
}
