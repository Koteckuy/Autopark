using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autopark.Models.Entities
{
    [Table("Route")]
    public class Route : BaseModel
    {
		public string Name { get; set; }
    
        public virtual ICollection<FuelRate> FuelRates { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
