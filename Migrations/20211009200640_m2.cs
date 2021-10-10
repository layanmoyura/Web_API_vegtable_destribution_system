using Microsoft.EntityFrameworkCore.Migrations;

namespace Online_platform_for_vegetables.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderID",
                table: "Deliveries",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_OrderID",
                table: "Deliveries",
                column: "OrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_Orders_OrderID",
                table: "Deliveries",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_Orders_OrderID",
                table: "Deliveries");

            migrationBuilder.DropIndex(
                name: "IX_Deliveries_OrderID",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "OrderID",
                table: "Deliveries");
        }
    }
}
