using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mime;

namespace Catering_WebAPI.Entities
{
    public class Order
    {
        public int OrderID { get; set; }  
        public int CustomerID { get; set; }
        public string Status { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Prize { get; set; }
        public List<CateringType> CateringTypes { get; set; }

    }
}
