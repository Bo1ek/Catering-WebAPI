using System.ComponentModel.DataAnnotations;

namespace Catering_WebAPI.Entities
{
    public class CateringType
    {
        public int CateringTypeId { get; set; }

        public virtual int CateringDietType
        {
            get => (int)this.DietType;
            set => DietType = (DietType)value;
        }
        [EnumDataType(typeof(DietType))]
        public DietType DietType { get; set; }
        public List<Order> Orders { get; set; }
    }
}
