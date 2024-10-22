using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebNhaHang.Models
{
    public class Ingredient
    {
        [Key]
        public int Ingredient_ID { get; set; }

        public string IngredientName { get; set; }

        public decimal QuantityInStock { get; set; }

        public string Unit { get; set; }
    }


}
