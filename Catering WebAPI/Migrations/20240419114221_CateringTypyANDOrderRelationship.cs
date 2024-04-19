using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Catering_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class CateringTypyANDOrderRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_CateringTypes_CateringTypesCateringTypeID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CateringTypesCateringTypeID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CateringTypesCateringTypeID",
                table: "Orders");

            migrationBuilder.AlterColumn<decimal>(
                name: "Prize",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.CreateTable(
                name: "CateringTypeOrder",
                columns: table => new
                {
                    CateringTypesCateringTypeID = table.Column<int>(type: "int", nullable: false),
                    OrdersOrderID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CateringTypeOrder", x => new { x.CateringTypesCateringTypeID, x.OrdersOrderID });
                    table.ForeignKey(
                        name: "FK_CateringTypeOrder_CateringTypes_CateringTypesCateringTypeID",
                        column: x => x.CateringTypesCateringTypeID,
                        principalTable: "CateringTypes",
                        principalColumn: "CateringTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CateringTypeOrder_Orders_OrdersOrderID",
                        column: x => x.OrdersOrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CateringTypeOrder_OrdersOrderID",
                table: "CateringTypeOrder",
                column: "OrdersOrderID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CateringTypeOrder");

            migrationBuilder.AlterColumn<decimal>(
                name: "Prize",
                table: "Orders",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<int>(
                name: "CateringTypesCateringTypeID",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CateringTypesCateringTypeID",
                table: "Orders",
                column: "CateringTypesCateringTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_CateringTypes_CateringTypesCateringTypeID",
                table: "Orders",
                column: "CateringTypesCateringTypeID",
                principalTable: "CateringTypes",
                principalColumn: "CateringTypeID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
