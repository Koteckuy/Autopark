using System.ComponentModel.DataAnnotations.Schema;

namespace Autopark.Models.Entities
{
    [Table("TrackSheetTask")]
    public class TrackSheetTask
	{
		public int ID { get; set; }
        [ForeignKey("TrackSheetID")]
        public int TrackSheetID { get; set; }
        [ForeignKey("TaskID")]
        public int TaskID { get; set; }
        public bool Deleted { get; set; }

        public virtual TrackSheet TrackSheet { get; set; }
        public virtual Task Task { get; set; }
    }
}