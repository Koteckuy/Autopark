using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autopark.Models.Entities
{
    [Table("Fuel")]
    public class Fuel
	{
		public int ID { get; set; }
		public string Name { get; set; }
        public string Unit { get; set; }
        public bool Deleted { get; set; }

        public virtual ICollection<FuelRate> FuelRates { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}
