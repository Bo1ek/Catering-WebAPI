using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Catering_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class OrderPosition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CateringTypeOrder_CateringTypes_CateringTypesCateringTypeID",
                table: "CateringTypeOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_CateringTypeOrder_Orders_OrdersOrderID",
                table: "CateringTypeOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerID",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "Orders",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "OrderID",
                table: "Orders",
                newName: "OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders",
                newName: "IX_Orders_CustomerId");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Customers",
                newName: "CustomerID");

            migrationBuilder.RenameColumn(
                name: "CateringTypeID",
                table: "CateringTypes",
                newName: "CateringTypeId");

            migrationBuilder.RenameColumn(
                name: "OrdersOrderID",
                table: "CateringTypeOrder",
                newName: "OrdersOrderId");

            migrationBuilder.RenameColumn(
                name: "CateringTypesCateringTypeID",
                table: "CateringTypeOrder",
                newName: "CateringTypesCateringTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_CateringTypeOrder_OrdersOrderID",
                table: "CateringTypeOrder",
                newName: "IX_CateringTypeOrder_OrdersOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_CateringTypeOrder_CateringTypes_CateringTypesCateringTypeId",
                table: "CateringTypeOrder",
                column: "CateringTypesCateringTypeId",
                principalTable: "CateringTypes",
                principalColumn: "CateringTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CateringTypeOrder_Orders_OrdersOrderId",
                table: "CateringTypeOrder",
                column: "OrdersOrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CateringTypeOrder_CateringTypes_CateringTypesCateringTypeId",
                table: "CateringTypeOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_CateringTypeOrder_Orders_OrdersOrderId",
                table: "CateringTypeOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Orders",
                newName: "CustomerID");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "Orders",
                newName: "OrderID");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                newName: "IX_Orders_CustomerID");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "Customers",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "CateringTypeId",
                table: "CateringTypes",
                newName: "CateringTypeID");

            migrationBuilder.RenameColumn(
                name: "OrdersOrderId",
                table: "CateringTypeOrder",
                newName: "OrdersOrderID");

            migrationBuilder.RenameColumn(
                name: "CateringTypesCateringTypeId",
                table: "CateringTypeOrder",
                newName: "CateringTypesCateringTypeID");

            migrationBuilder.RenameIndex(
                name: "IX_CateringTypeOrder_OrdersOrderId",
                table: "CateringTypeOrder",
                newName: "IX_CateringTypeOrder_OrdersOrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_CateringTypeOrder_CateringTypes_CateringTypesCateringTypeID",
                table: "CateringTypeOrder",
                column: "CateringTypesCateringTypeID",
                principalTable: "CateringTypes",
                principalColumn: "CateringTypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CateringTypeOrder_Orders_OrdersOrderID",
                table: "CateringTypeOrder",
                column: "OrdersOrderID",
                principalTable: "Orders",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerID",
                table: "Orders",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
