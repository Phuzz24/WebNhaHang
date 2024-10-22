using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebNhaHang.Models
{
    public class ThongKe
    {
        [Key]
        public int Statistic_ID { get; set; }

        public DateTime Date { get; set; }

        public int TotalOrders { get; set; }

        public decimal TotalRevenue { get; set; }

        public decimal TotalExpenses { get; set; }

        public decimal Profit { get; set; }
    }


}
