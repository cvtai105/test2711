using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace test2711.Migrations
{
    /// <inheritdoc />
    public partial class seed_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Inserting seed data into Products table
            migrationBuilder.Sql(
                "INSERT INTO Products (ProductName, Price, StockQuantity) VALUES " +
                "('Product 1', 19.99, 100), " +
                "('Product 2', 29.99, 200), " +
                "('Product 3', 39.99, 150), " +
                "('Product 4', 49.99, 50), " +
                "('Product 5', 59.99, 300);"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Optionally delete the seeded data. Typically you don't remove seed data in Down method, but if needed:
            migrationBuilder.Sql(
                "DELETE FROM Products WHERE ProductName IN ('Product 1', 'Product 2', 'Product 3', 'Product 4', 'Product 5');"
            );
        }
    }
}
