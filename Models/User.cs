using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebNhaHang.Models
{
    public class User
    {
        [Key]
        [Column("user_id")]

        public int User_ID { get; set; }

        [MaxLength(100)]
        [Column("username")]

        public string Username { get; set; }

        [MaxLength(100)]
        [Column("password")]

        public string Password { get; set; }

        [MaxLength(50)]
        [Column("role")]

        public string Role { get; set; }

        // Điều hướng đến các bảng liên kết
        public ICollection<Admin> Admins { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}
