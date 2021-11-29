using System.ComponentModel.DataAnnotations.Schema;

namespace Autopark.Models.Entities
{
    [Table("TrackSheetTask")]
    public class TrackSheetTask : BaseModel
    {
        [ForeignKey("TrackSheetID")]
        public int TrackSheetID { get; set; }
        [ForeignKey("TaskID")]
        public int TaskID { get; set; }

        public virtual TrackSheet TrackSheet { get; set; }
        public virtual Task Task { get; set; }
    }
}