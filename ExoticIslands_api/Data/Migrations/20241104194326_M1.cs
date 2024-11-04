using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

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
                values: new object[] { 1, "", "French Polynesia", "Famous for its seaside luxury resorts, turquoise lagoons, and coral reefs.", "Bora Bora" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Islands");
        }
    }
}
