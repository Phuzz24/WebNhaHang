using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebNhaHang.Models
{
    public class RestaurantTable
    {
        [Key]
        public int Table_ID { get; set; }

        public int TableNumber { get; set; }

        public int SeatingCapacity { get; set; }
    }


}
