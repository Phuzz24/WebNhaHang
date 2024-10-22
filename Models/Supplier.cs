using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebNhaHang.Models
{
    public class Supplier
    {
        [Key]
        public int Supplier_ID { get; set; }

        public string SupplierName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }
    }


}
