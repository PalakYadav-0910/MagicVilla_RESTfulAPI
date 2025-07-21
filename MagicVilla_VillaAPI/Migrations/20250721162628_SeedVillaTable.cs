using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "VillaTable",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Pool, WiFi, Breakfast", new DateTime(2025, 7, 21, 21, 56, 28, 200, DateTimeKind.Local).AddTicks(1567), "This is a detailed description of the Royal Villa.", "https://example.com/royal-villa.jpg", "Royal Villa", 4, 200.0, 500, new DateTime(2025, 7, 21, 21, 56, 28, 200, DateTimeKind.Local).AddTicks(1579) },
                    { 2, "Spa, Gym, WiFi", new DateTime(2025, 7, 21, 21, 56, 28, 200, DateTimeKind.Local).AddTicks(1582), "This is a detailed description of the Luxury Villa.", "https://example.com/luxury-villa.jpg", "Luxury Villa", 6, 300.0, 600, new DateTime(2025, 7, 21, 21, 56, 28, 200, DateTimeKind.Local).AddTicks(1582) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VillaTable",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VillaTable",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
