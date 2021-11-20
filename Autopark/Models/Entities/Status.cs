using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autopark.Models.Entities
{
    [Table("Status")]
    public class Status
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool Deleted { get; set; }

        public virtual ICollection<TrackSheet> TrackSheets { get; set; }
    }
}
