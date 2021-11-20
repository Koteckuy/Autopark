using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autopark.Models.Entities
{
    [Table("Task")]
	public class Task
	{
		public int ID { get; set; }
		[ForeignKey("CustomerID")]
		public int CustomerID { get; set; }
		[ForeignKey("RouteID")]
		public int RouteID { get; set; }
        public int Mileage { get; set; }
        public string Details { get; set; }
        public bool Deleted { get; set; }
	
		public virtual Employee Customer { get; set; }
		public virtual Route Route { get; set; }

		public virtual ICollection<TrackSheetTask> TrackSheetTasks { get; set; }
	}
}