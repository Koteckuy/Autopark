using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AISTest.Models
{
    [Table("TrackSheetTask")]
    public class TrackSheetTask
	{
		public int ID { get; set; }
		public int TrackSheetID { get; set; }
        public int TaskID { get; set; }
        public bool Deleted { get; set; }

        public virtual TrackSheet TrackSheet { get; set; }
        public virtual Task Task { get; set; }
    }
}