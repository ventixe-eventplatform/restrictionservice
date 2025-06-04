using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Restrictions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restrictions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Restrictions",
                columns: new[] { "Id", "Description", "ImageUrl" },
                values: new object[,]
                {
                    { 1, "Weapons and Dangerous Items", "https://ventixedatastorage.blob.core.windows.net/images/prohibited-item-1.svg" },
                    { 2, "Illegal Substances", "https://ventixedatastorage.blob.core.windows.net/images/prohibited-item-2.svg" },
                    { 3, "Alcohol and Beverages", "https://ventixedatastorage.blob.core.windows.net/images/prohibited-item-3.svg" },
                    { 4, "Recording Equipment", "https://ventixedatastorage.blob.core.windows.net/images/prohibited-item-4.svg" },
                    { 5, "Large or Hazardous Items", "https://ventixedatastorage.blob.core.windows.net/images/prohibited-item-5.svg" },
                    { 6, "Noise Makers and Disruptive Items", "https://ventixedatastorage.blob.core.windows.net/images/prohibited-item-6.svg" },
                    { 7, "Unauthorized Merchandise", "https://ventixedatastorage.blob.core.windows.net/images/prohibited-item-7.svg" },
                    { 8, "Pets and Animals", "https://ventixedatastorage.blob.core.windows.net/images/prohibited-item-8.svg" },
                    { 9, "Bicycles, Skateboards, or Hoverboards", "https://ventixedatastorage.blob.core.windows.net/images/prohibited-item-9.svg" },
                    { 10, "Coolers or Picnic Baskets", "https://ventixedatastorage.blob.core.windows.net/images/prohibited-item-10.svg" },
                    { 11, "Umbrellas or Large Parasols", "https://ventixedatastorage.blob.core.windows.net/images/prohibited-item-11.svg" },
                    { 12, "Camping Gear", "https://ventixedatastorage.blob.core.windows.net/images/prohibited-item-12.svg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Restrictions");
        }
    }
}
