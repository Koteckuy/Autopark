using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autopark.Models.Entities
{
    [Table("Brand")]
    public class Brand
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool Deleted { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
	}
}