using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autopark.Models.Entities
{
    [Table("Department")]
    public class Department : BaseModel
    {
        public string Name { get; set; }

        public virtual ICollection<Position> Positions { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
