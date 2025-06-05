using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ambev.DeveloperEvaluation.ORM.Migrations
{
    /// <inheritdoc />
    public partial class RefactorNammingConventionsAndInitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    sku_value = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    info_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    info_description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    price_value = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    price_currency = table.Column<int>(type: "integer", maxLength: 3, nullable: true),
                    image_url = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_products", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    username = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    phone = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    password = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    role = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    status = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_users", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "id", "created_at", "updated_at", "price_currency", "price_value", "image_url", "info_description", "info_name", "sku_value" },
                values: new object[,]
                {
                    { new Guid("637bca77-4d2b-499e-bfe6-a0e5fa0e1257"), new DateTime(1986, 1, 28, 11, 39, 0, 0, DateTimeKind.Utc), new DateTime(1986, 1, 28, 11, 39, 0, 0, DateTimeKind.Utc), 1, 19.9m, "https://ambev.developer.evaluation/product1.jpg", "Description for Product 1", "Product 1", "PROD-001" },
                    { new Guid("d3baf233-68da-4b9a-871a-8f0aa723101b"), new DateTime(1986, 4, 26, 1, 23, 0, 0, DateTimeKind.Utc), new DateTime(1986, 4, 26, 1, 23, 0, 0, DateTimeKind.Utc), 1, 29.9m, "https://ambev.developer.evaluation/product2.jpg", "Description for Product 2", "Product 2", "PROD-002" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
