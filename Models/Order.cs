using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebNhaHang.Models
{
    public class Order
    {
        [Key]
        public int Order_ID { get; set; }

        public int Customer_ID { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal TotalAmount { get; set; }

        public string PaymentStatus { get; set; }

        public Customer Customer { get; set; }
    }


}
