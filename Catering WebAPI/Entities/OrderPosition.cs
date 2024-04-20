using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Catering_WebAPI.Entities
{
    public class OrderPosition
    {
        public required int OrderPositionId { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Prize { get; set; }
        public DietTypes DietType { get; set; }
        public int[] CalorieVariants { get; } = [1700,2000,2300,2600,3000,3500,4000];
        public List<CateringType> CateringTypes { get; set; }
        public List<Order> Orders { get; set; }
        public List<Order> OrderID { get; set; }
    }
}
