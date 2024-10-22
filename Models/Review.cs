using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebNhaHang.Models
{
    public class Review
    {
        [Key]
        public int Review_ID { get; set; }

        public int Customer_ID { get; set; }
        [ForeignKey("Menu")]

        public int Dish_ID { get; set; }

        public int Rating { get; set; }

        public string Comment { get; set; }

        public DateTime ReviewDate { get; set; }

        public Customer Customer { get; set; }
        public Menu Menu { get; set; }
    }


}
