using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using WebNhaHang.Models;

namespace WebNhaHang.Models { 
    public class DBNhaHangContext : DbContext
    {
        public DBNhaHangContext(DbContextOptions<DBNhaHangContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Menu> Menus { get; set; } // Đảm bảo khai báo DbSet có 's'
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<ThongKe> ThongKes { get; set; }
        public DbSet<RestaurantTable> Table1s { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Cấu hình mối quan hệ giữa Menu và Brand
            modelBuilder.Entity<Menu>()
                .HasOne(m => m.Brand)
                .WithMany()  // Nếu không có collection của Menu trong Brand, dùng WithMany()
                .HasForeignKey(m => m.Brand_ID);

            // Cấu hình tương tự cho Category nếu có
            modelBuilder.Entity<Menu>()
                .HasOne(m => m.Category)
                .WithMany()
                .HasForeignKey(m => m.Category_ID);

            modelBuilder.Entity<Customer>()
       .HasOne(c => c.User)
       .WithMany(u => u.Customers)
       .HasForeignKey(c => c.User_ID);
        }


    }
}