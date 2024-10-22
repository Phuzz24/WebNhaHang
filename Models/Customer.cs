using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebNhaHang.Models
{
    public class Customer
    {
        [Key]
        [Column("customer_id")]

        public int Customer_ID { get; set; }
        [ForeignKey("User")]

        [Column("user_id")]

        public int User_ID { get; set; }
        [Column("full_name")]

        public string? FullName { get; set; }
        [Column("address")]

        public string? Address { get; set; }
        [Column("phone_number")]

        public string? PhoneNumber { get; set; }
        [Column("email")]

        public string Email { get; set; }

        // Điều hướng đến User
        public User User { get; set; }
    }

}
