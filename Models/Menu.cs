using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebNhaHang.Models
{
    public class Menu
    {
        [Key]
        public int Dish_ID { get; set; }
        [Required]
        [Column("dish_name")]
        public string DishName { get; set; } = "Tên món ăn không có";  // Giá trị mặc định

        public decimal Price { get; set; }

        public string Description { get; set; }
        [Required]

        [Column("dish_image")]
        public string DishImage { get; set; } = "/path/to/default-image.png"; 
        [ForeignKey("Category")]

        public int Category_ID { get; set; }
        [ForeignKey("Brand")]

        public int Brand_ID { get; set; }

        public int? Quantity { get; set; }

        public string Status { get; set; }

        public Category Category { get; set; }
        public Brand Brand { get; set; }
    }



}
