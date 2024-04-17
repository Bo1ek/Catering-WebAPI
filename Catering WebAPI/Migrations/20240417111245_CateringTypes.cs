using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Catering_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class CateringTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CateringTypesCateringTypeID",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Prize",
                table: "Orders",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "CateringTypes",
                columns: table => new
                {
                    CateringTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CateringDietType = table.Column<int>(type: "int", nullable: false),
                    DietType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CateringTypes", x => x.CateringTypeID);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_CateringTypes_CateringTypesCateringTypeID",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "CateringTypes");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CateringTypesCateringTypeID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CateringTypesCateringTypeID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Prize",
                table: "Orders");
        }
    }
}
