﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebNhaHang.Models;

#nullable disable

namespace WebNhaHang.Migrations
{
    [DbContext(typeof(DBNhaHangContext))]
    partial class DBNhaHangContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebNhaHang.Models.Admin", b =>
                {
                    b.Property<int>("Admin_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Admin_ID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("User_ID")
                        .HasColumnType("int");

                    b.Property<int>("User_ID1")
                        .HasColumnType("int");

                    b.HasKey("Admin_ID");

                    b.HasIndex("User_ID1");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("WebNhaHang.Models.Brand", b =>
                {
                    b.Property<int>("Brand_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Brand_ID"));

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Brand_ID");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("WebNhaHang.Models.Category", b =>
                {
                    b.Property<int>("Category_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Category_ID"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Category_ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("WebNhaHang.Models.Customer", b =>
                {
                    b.Property<int>("Customer_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Customer_ID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("User_ID")
                        .HasColumnType("int");

                    b.Property<int>("User_ID1")
                        .HasColumnType("int");

                    b.HasKey("Customer_ID");

                    b.HasIndex("User_ID1");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("WebNhaHang.Models.Employee", b =>
                {
                    b.Property<int>("Employee_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Employee_ID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("User_ID")
                        .HasColumnType("int");

                    b.Property<int>("User_ID1")
                        .HasColumnType("int");

                    b.HasKey("Employee_ID");

                    b.HasIndex("User_ID1");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("WebNhaHang.Models.Ingredient", b =>
                {
                    b.Property<int>("Ingredient_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Ingredient_ID"));

                    b.Property<string>("IngredientName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("QuantityInStock")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Ingredient_ID");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("WebNhaHang.Models.Menu", b =>
                {
                    b.Property<int>("Dish_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Dish_ID"));

                    b.Property<int?>("Brand_ID")
                        .HasColumnType("int");

                    b.Property<int>("Brand_ID1")
                        .HasColumnType("int");

                    b.Property<int?>("Category_ID")
                        .HasColumnType("int");

                    b.Property<int>("Category_ID1")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DishImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DishName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Dish_ID");

                    b.HasIndex("Brand_ID1");

                    b.HasIndex("Category_ID1");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("WebNhaHang.Models.Order", b =>
                {
                    b.Property<int>("Order_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Order_ID"));

                    b.Property<int>("Customer_ID")
                        .HasColumnType("int");

                    b.Property<int>("Customer_ID1")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Order_ID");

                    b.HasIndex("Customer_ID1");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("WebNhaHang.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetail_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderDetail_ID"));

                    b.Property<int>("Dish_ID")
                        .HasColumnType("int");

                    b.Property<int>("MenuDish_ID")
                        .HasColumnType("int");

                    b.Property<int>("Order_ID")
                        .HasColumnType("int");

                    b.Property<int>("Order_ID1")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderDetail_ID");

                    b.HasIndex("MenuDish_ID");

                    b.HasIndex("Order_ID1");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("WebNhaHang.Models.PurchaseOrder", b =>
                {
                    b.Property<int>("PurchaseOrder_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PurchaseOrder_ID"));

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Supplier_ID")
                        .HasColumnType("int");

                    b.Property<int>("Supplier_ID1")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("PurchaseOrder_ID");

                    b.HasIndex("Supplier_ID1");

                    b.ToTable("PurchaseOrders");
                });

            modelBuilder.Entity("WebNhaHang.Models.PurchaseOrderDetail", b =>
                {
                    b.Property<int>("PurchaseOrderDetail_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PurchaseOrderDetail_ID"));

                    b.Property<int>("Ingredient_ID")
                        .HasColumnType("int");

                    b.Property<int>("Ingredient_ID1")
                        .HasColumnType("int");

                    b.Property<int>("PurchaseOrder_ID")
                        .HasColumnType("int");

                    b.Property<int>("PurchaseOrder_ID1")
                        .HasColumnType("int");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("PurchaseOrderDetail_ID");

                    b.HasIndex("Ingredient_ID1");

                    b.HasIndex("PurchaseOrder_ID1");

                    b.ToTable("PurchaseOrderDetails");
                });

            modelBuilder.Entity("WebNhaHang.Models.Reservation", b =>
                {
                    b.Property<int>("Reservation_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Reservation_ID"));

                    b.Property<int>("Customer_ID")
                        .HasColumnType("int");

                    b.Property<int>("Customer_ID1")
                        .HasColumnType("int");

                    b.Property<int>("NumOfPeople")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RestaurantTableTable_ID")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Table_ID")
                        .HasColumnType("int");

                    b.HasKey("Reservation_ID");

                    b.HasIndex("Customer_ID1");

                    b.HasIndex("RestaurantTableTable_ID");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("WebNhaHang.Models.RestaurantTable", b =>
                {
                    b.Property<int>("Table_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Table_ID"));

                    b.Property<int>("SeatingCapacity")
                        .HasColumnType("int");

                    b.Property<int>("TableNumber")
                        .HasColumnType("int");

                    b.HasKey("Table_ID");

                    b.ToTable("Table1s");
                });

            modelBuilder.Entity("WebNhaHang.Models.Review", b =>
                {
                    b.Property<int>("Review_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Review_ID"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Customer_ID")
                        .HasColumnType("int");

                    b.Property<int>("Customer_ID1")
                        .HasColumnType("int");

                    b.Property<int>("Dish_ID")
                        .HasColumnType("int");

                    b.Property<int>("MenuDish_ID")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReviewDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Review_ID");

                    b.HasIndex("Customer_ID1");

                    b.HasIndex("MenuDish_ID");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("WebNhaHang.Models.Supplier", b =>
                {
                    b.Property<int>("Supplier_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Supplier_ID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Supplier_ID");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("WebNhaHang.Models.ThongKe", b =>
                {
                    b.Property<int>("Statistic_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Statistic_ID"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Profit")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalExpenses")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TotalOrders")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalRevenue")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Statistic_ID");

                    b.ToTable("ThongKes");
                });

            modelBuilder.Entity("WebNhaHang.Models.User", b =>
                {
                    b.Property<int>("User_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("User_ID"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("User_ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WebNhaHang.Models.Admin", b =>
                {
                    b.HasOne("WebNhaHang.Models.User", "User")
                        .WithMany("Admins")
                        .HasForeignKey("User_ID1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebNhaHang.Models.Customer", b =>
                {
                    b.HasOne("WebNhaHang.Models.User", "User")
                        .WithMany("Customers")
                        .HasForeignKey("User_ID1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebNhaHang.Models.Employee", b =>
                {
                    b.HasOne("WebNhaHang.Models.User", "User")
                        .WithMany("Employees")
                        .HasForeignKey("User_ID1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebNhaHang.Models.Menu", b =>
                {
                    b.HasOne("WebNhaHang.Models.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("Brand_ID1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebNhaHang.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("Category_ID1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("WebNhaHang.Models.Order", b =>
                {
                    b.HasOne("WebNhaHang.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("Customer_ID1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("WebNhaHang.Models.OrderDetail", b =>
                {
                    b.HasOne("WebNhaHang.Models.Menu", "Menu")
                        .WithMany()
                        .HasForeignKey("MenuDish_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebNhaHang.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("Order_ID1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Menu");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("WebNhaHang.Models.PurchaseOrder", b =>
                {
                    b.HasOne("WebNhaHang.Models.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("Supplier_ID1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("WebNhaHang.Models.PurchaseOrderDetail", b =>
                {
                    b.HasOne("WebNhaHang.Models.Ingredient", "Ingredient")
                        .WithMany()
                        .HasForeignKey("Ingredient_ID1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebNhaHang.Models.PurchaseOrder", "PurchaseOrder")
                        .WithMany()
                        .HasForeignKey("PurchaseOrder_ID1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("PurchaseOrder");
                });

            modelBuilder.Entity("WebNhaHang.Models.Reservation", b =>
                {
                    b.HasOne("WebNhaHang.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("Customer_ID1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebNhaHang.Models.RestaurantTable", "RestaurantTable")
                        .WithMany()
                        .HasForeignKey("RestaurantTableTable_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("RestaurantTable");
                });

            modelBuilder.Entity("WebNhaHang.Models.Review", b =>
                {
                    b.HasOne("WebNhaHang.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("Customer_ID1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebNhaHang.Models.Menu", "Menu")
                        .WithMany()
                        .HasForeignKey("MenuDish_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Menu");
                });

            modelBuilder.Entity("WebNhaHang.Models.User", b =>
                {
                    b.Navigation("Admins");

                    b.Navigation("Customers");

                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
