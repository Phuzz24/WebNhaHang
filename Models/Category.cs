using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebNhaHang.Models
{
    public class Category
    {
        [Key]
        public int Category_ID { get; set; }

        public string CategoryName { get; set; }
    }


}
