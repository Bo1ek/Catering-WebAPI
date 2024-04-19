using System.ComponentModel.DataAnnotations;

namespace Catering_WebAPI.Entities
{
    public class CateringType
    {
        public int CateringTypeID { get; set; }

        public virtual int CateringDietType
        {
            get => (int)this.DietType;
            set => DietType = (DietTypes)value;
        }
        [EnumDataType(typeof(DietTypes))]
        public DietTypes DietType { get; set; }
    }
    public enum DietTypes
    {
        Keto = 0,
        Protein = 1,
        LowCarb = 2,
        Sport = 3
    }
}
