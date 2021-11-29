using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autopark.Models.Entities
{
    [Table("Brand")]
    public class Brand : BaseModel
    {
        public string Name { get; set; }

        public virtual ICollection<Car> Cars { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}