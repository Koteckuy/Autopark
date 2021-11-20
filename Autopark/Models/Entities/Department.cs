using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autopark.Models.Entities
{
    [Table("Department")]
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool Deleted { get; set; }

        public virtual ICollection<Position> Positions { get; set; }
    }
}
