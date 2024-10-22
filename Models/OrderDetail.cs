using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebNhaHang.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetail_ID { get; set; }

        public int Order_ID { get; set; }

        public int Dish_ID { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public Order Order { get; set; }
        public Menu Menu { get; set; }
    }


}
