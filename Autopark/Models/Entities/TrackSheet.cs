using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AISTest.Models
{
    [Table("TrackSheet")]
    public class TrackSheet
	{
        public int ID { get; set; }
        public int DriverID { get; set; }
        public int CarID { get; set; }
		public DateTime ReportDate { get; set; }
        public int StatusID { get; set; }
        public int CheckerID { get; set; }
        public int AuthorizedID { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan ReturnTime { get; set; }
        public bool Deleted { get; set; }
    
        public virtual Employee Driver { get; set; }
        public virtual Car Car { get; set; }
        public virtual Status Status { get; set; }
        public virtual Employee Checker { get; set; }
        public virtual Employee Authorized { get; set; }

        public virtual ICollection<TrackSheetTask> TrackSheetTasks { get; set; }
    }
}
