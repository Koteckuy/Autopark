using System.ComponentModel.DataAnnotations.Schema;

namespace Autopark.Models.Entities
{
    [Table("FuelRate")]
    public class FuelRate : BaseModel
    {
        [ForeignKey("FuelID")]
        public int FuelID { get; set; }
        [ForeignKey("RouteID")]
        public int RouteID { get; set; }
        public float Rate { get; set; }

        public virtual Fuel Fuel { get; set; }
        public virtual Route Route { get; set; }
    }
}