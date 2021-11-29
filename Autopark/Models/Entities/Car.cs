using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autopark.Models.Entities
{
    [Table("Car")]
    public class Car : BaseModel
    {
        [ForeignKey("BrandID")]
        public int BrandID { get; set; }
        public string Model { get; set; }
        public string LicensePlate { get; set; }
        public int Mileage { get; set; }
        [ForeignKey("FuelID")]
        public int FuelID { get; set; }
        public float FuelRemaining { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual Fuel Fuel { get; set; }

        public virtual ICollection<TrackSheet> TrackSheets { get; set; }

        public override string ToString()
        {
            return Brand.Name + Model;
        }
    }
}