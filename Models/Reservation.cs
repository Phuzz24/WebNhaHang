using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebNhaHang.Models
{
    public class Reservation
    {
        [Key]
        public int Reservation_ID { get; set; }

        public int Customer_ID { get; set; }

        public DateTime ReservationDate { get; set; }

        public int NumOfPeople { get; set; }
        [ForeignKey("RestaurantTable")]

        public int Table_ID { get; set; }

        public string Status { get; set; }

        public Customer Customer { get; set; }
        public RestaurantTable RestaurantTable { get; set; }
    }


}
