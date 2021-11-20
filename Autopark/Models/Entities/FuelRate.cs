using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AISTest.Models
{
    [Table("FuelRate")]
    public class FuelRate
	{
		public int ID { get; set; }
		public int FuelID { get; set; }
        public int RouteID { get; set; }
        public float Rate { get; set; }
        public bool Deleted { get; set; }

        public virtual Fuel Fuel { get; set; }
        public virtual Route Route { get; set; }
	}
}