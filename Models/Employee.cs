using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebNhaHang.Models
{
    public class Employee
    {
        [Key]
        public int Employee_ID { get; set; }

        public int User_ID { get; set; }

        [MaxLength(100)]
        public string FullName { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }
        // Điều hướng đến User
        public User User { get; set; }
    }

}
