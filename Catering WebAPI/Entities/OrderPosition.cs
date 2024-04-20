using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Catering_WebAPI.Entities
{
    public class OrderPosition
    {
        public required int OrderPositionId { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Prize { get; set; }
        public DietType DietType { get; set; }
        public int CalorieVariantId { get; set; }
        public List<CateringType> CateringTypes { get; set; }
        public int OrderId { get; set; }
    }
}
