using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Catering_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseFixes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CateringTypeOrder");

            migrationBuilder.AddColumn<int>(
                name: "CateringTypeId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderPositionId",
                table: "CateringTypes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CalorieVariants",
                columns: table => new
                {
                    CalorieVariantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Calories = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalorieVariants", x => x.CalorieVariantId);
                });

            migrationBuilder.CreateTable(
                name: "OrderPositions",
                columns: table => new
                {
                    OrderPositionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prize = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DietType = table.Column<int>(type: "int", nullable: false),
                    CalorieVariantId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderPositions", x => x.OrderPositionId);
                    table.ForeignKey(
                        name: "FK_OrderPositions_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CateringTypeId",
                table: "Orders",
                column: "CateringTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CateringTypes_OrderPositionId",
                table: "CateringTypes",
                column: "OrderPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderPositions_OrderId",
                table: "OrderPositions",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_CateringTypes_OrderPositions_OrderPositionId",
                table: "CateringTypes",
                column: "OrderPositionId",
                principalTable: "OrderPositions",
                principalColumn: "OrderPositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_CateringTypes_CateringTypeId",
                table: "Orders",
                column: "CateringTypeId",
                principalTable: "CateringTypes",
                principalColumn: "CateringTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CateringTypes_OrderPositions_OrderPositionId",
                table: "CateringTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_CateringTypes_CateringTypeId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "CalorieVariants");

            migrationBuilder.DropTable(
                name: "OrderPositions");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CateringTypeId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_CateringTypes_OrderPositionId",
                table: "CateringTypes");

            migrationBuilder.DropColumn(
                name: "CateringTypeId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderPositionId",
                table: "CateringTypes");

            migrationBuilder.CreateTable(
                name: "CateringTypeOrder",
                columns: table => new
                {
                    CateringTypesCateringTypeId = table.Column<int>(type: "int", nullable: false),
                    OrdersOrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CateringTypeOrder", x => new { x.CateringTypesCateringTypeId, x.OrdersOrderId });
                    table.ForeignKey(
                        name: "FK_CateringTypeOrder_CateringTypes_CateringTypesCateringTypeId",
                        column: x => x.CateringTypesCateringTypeId,
                        principalTable: "CateringTypes",
                        principalColumn: "CateringTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CateringTypeOrder_Orders_OrdersOrderId",
                        column: x => x.OrdersOrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CateringTypeOrder_OrdersOrderId",
                table: "CateringTypeOrder",
                column: "OrdersOrderId");
        }
    }
}
