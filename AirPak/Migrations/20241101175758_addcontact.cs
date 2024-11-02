using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AirPak.Migrations
{
    /// <inheritdoc />
    public partial class addcontact : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "95221573-a9dc-428a-9222-5e5717f4d2ef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad45e6c3-6271-4f68-8ff3-7d98eace623a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8c023564-fb33-4921-97f0-63d73ae5ade0", null, "admin", "ADMIN" },
                    { "efec287d-2132-43ce-849e-dda06ef041fc", null, "customer", "CUSTOMER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c023564-fb33-4921-97f0-63d73ae5ade0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "efec287d-2132-43ce-849e-dda06ef041fc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "95221573-a9dc-428a-9222-5e5717f4d2ef", null, "customer", "CUSTOMER" },
                    { "ad45e6c3-6271-4f68-8ff3-7d98eace623a", null, "admin", "ADMIN" }
                });
        }
    }
}
