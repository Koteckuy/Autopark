using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autopark.Models.Entities
{
    [Table("Status")]
    public class Status : BaseModel
    {
        public string Name { get; set; }

        public virtual ICollection<TrackSheet> TrackSheets { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
