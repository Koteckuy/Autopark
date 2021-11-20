using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AISTest.Models
{
    [Table("Employee")]
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        [ForeignKey("PositionID")]
        public int PositionID { get; set; }
        public bool Deleted { get; set; }

        public virtual Position Position { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
        public virtual ICollection<TrackSheet> DriverTrackSheets { get; set; }
        public virtual ICollection<TrackSheet> CheckerTrackSheets { get; set; }
        public virtual ICollection<TrackSheet> AuthorizedTrackSheets { get; set; }
    }
}
