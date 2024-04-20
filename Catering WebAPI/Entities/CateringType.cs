using System.ComponentModel.DataAnnotations;

namespace Catering_WebAPI.Entities
{
    public class CateringType
    {
        public int CateringTypeId { get; set; }

        public virtual int CateringDietType
        {
            get => (int)this.DietType;
            set => DietType = (DietTypes)value;
        }
        [EnumDataType(typeof(DietTypes))]
        public DietTypes DietType { get; set; }
        public List<Order> Orders { get; set; }
    }
}
