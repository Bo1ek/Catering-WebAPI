using System.ComponentModel.DataAnnotations.Schema;

namespace Catering_WebAPI.Entities
{
    public class OrderPosition
    {
        public required int OrderPositionID { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Prize { get; set; }
        public string DietType { get; set; }
        public int DietVariant { get; set; }
        public List<CateringType> CateringTypes { get; set; }
        public List<Order> Orders { get; set; }
        public List<Order> OrderID { get; set; }

    }
}
