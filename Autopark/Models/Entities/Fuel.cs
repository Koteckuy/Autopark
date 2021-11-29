using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autopark.Models.Entities
{
    [Table("Fuel")]
    public class Fuel : BaseModel
    {
		public string Name { get; set; }
        public string Unit { get; set; }

        public virtual ICollection<FuelRate> FuelRates { get; set; }
        public virtual ICollection<Car> Cars { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
