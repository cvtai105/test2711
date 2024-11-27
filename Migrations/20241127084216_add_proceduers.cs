using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace test2711.Migrations
{
    /// <inheritdoc />
    public partial class add_proceduers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
             migrationBuilder.Sql(@"
                CREATE PROCEDURE sp_GetAllProducts
                AS
                BEGIN
                    SELECT ProductId, ProductName, Price, StockQuantity FROM Products
                END
            ");

            // Tạo stored procedure sp_GetProductById
            migrationBuilder.Sql(@"
                CREATE PROCEDURE sp_GetProductById
                    @ProductId INT
                AS
                BEGIN
                    SELECT ProductId, ProductName, Price, StockQuantity FROM Products WHERE ProductId = @ProductId
                END
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Xóa stored procedure sp_GetAllProducts
            migrationBuilder.Sql("DROP PROCEDURE sp_GetAllProducts");

            // Xóa stored procedure sp_GetProductById
            migrationBuilder.Sql("DROP PROCEDURE sp_GetProductById");
        }
    }
}
