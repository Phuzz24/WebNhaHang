using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebNhaHang.Models
{
    public class PurchaseOrderDetail
    {
        [Key]
        public int PurchaseOrderDetail_ID { get; set; }

        public int PurchaseOrder_ID { get; set; }

        public int Ingredient_ID { get; set; }

        public decimal Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public PurchaseOrder PurchaseOrder { get; set; }
        public Ingredient Ingredient { get; set; }
    }

}
