using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISTest.Models
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
