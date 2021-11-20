using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AISTest.Models
{
    [Table("Route")]
    public class Route
	{
		public int ID { get; set; }
		public string Name { get; set; }
        public bool Deleted { get; set; }
    
        public virtual ICollection<FuelRate> FuelRates { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
