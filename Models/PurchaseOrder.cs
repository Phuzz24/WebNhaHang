using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebNhaHang.Models
{
    public class PurchaseOrder
    {
        [Key]
        public int PurchaseOrder_ID { get; set; }

        public int Supplier_ID { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal TotalAmount { get; set; }

        public Supplier Supplier { get; set; }
    }


}
