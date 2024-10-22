using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebNhaHang.Models
{
    public class Brand
    {
        [Key]
        [Column("brand_id")]

        public int Brand_ID { get; set; }
        [Column("brand_name")]

        public string BrandName { get; set; }
    }


}
