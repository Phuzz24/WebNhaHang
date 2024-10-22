using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebNhaHang.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.AddColumn<string>(
            name: "DishName",
            table: "Menus",
            nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "DishImage",
                table: "Menus",
                nullable: false);

           

            migrationBuilder.CreateIndex(
                name: "IX_Admins_User_ID1",
                table: "Admins",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_User_ID1",
                table: "Customers",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_User_ID1",
                table: "Employees",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_Brand_ID1",
                table: "Menus",
                column: "Brand_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_Category_ID1",
                table: "Menus",
                column: "Category_ID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_MenuDish_ID",
                table: "OrderDetails",
                column: "MenuDish_ID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_Order_ID1",
                table: "OrderDetails",
                column: "Order_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Customer_ID1",
                table: "Orders",
                column: "Customer_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderDetails_Ingredient_ID1",
                table: "PurchaseOrderDetails",
                column: "Ingredient_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderDetails_PurchaseOrder_ID1",
                table: "PurchaseOrderDetails",
                column: "PurchaseOrder_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrders_Supplier_ID1",
                table: "PurchaseOrders",
                column: "Supplier_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_Customer_ID1",
                table: "Reservations",
                column: "Customer_ID");

            migrationBuilder.CreateIndex(
       name: "IX_Reservations_Table_ID",
       table: "Reservations",
       column: "Table_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Table1s_Table_ID",
                table: "Reservations",
                column: "Table_ID",
                principalTable: "Table1s",
                principalColumn: "Table_ID",
                onDelete: ReferentialAction.Cascade);



            migrationBuilder.CreateIndex(
                name: "IX_Reviews_Customer_ID1",
                table: "Reviews",
                column: "Customer_ID");

            migrationBuilder.CreateIndex(
     name: "IX_Reviews_Dish_ID",
     table: "Reviews",
     column: "Dish_ID");
          




        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "PurchaseOrderDetails");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "ThongKes");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "PurchaseOrders");

            migrationBuilder.DropTable(
                name: "Table1s");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");
            migrationBuilder.DropColumn(
            name: "DishName",
            table: "Menus");

            migrationBuilder.DropColumn(
                name: "DishImage",
                table: "Menus");
        }
    }
}
