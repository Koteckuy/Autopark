using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autopark.Models.Entities
{
    [Table("TrackSheet")]
    public class TrackSheet : BaseModel
    {
        [ForeignKey("DriverID")]
        public int DriverID { get; set; }
        [ForeignKey("CarID")]
        public int CarID { get; set; }
		public DateTime ReportDate { get; set; }
        [ForeignKey("StatusID")]
        public int StatusID { get; set; }
        [ForeignKey("CheckerID")]
        public int CheckerID { get; set; }
        [ForeignKey("AuthorizedID")]
        public int AuthorizedID { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan ReturnTime { get; set; }
    
        public virtual Employee Driver { get; set; }
        public virtual Car Car { get; set; }
        public virtual Status Status { get; set; }
        public virtual Employee Checker { get; set; }
        public virtual Employee Authorized { get; set; }

        public virtual ICollection<TrackSheetTask> TrackSheetTasks { get; set; }
    }
}
