using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autopark.Models.Entities
{
    [Table("Position")]
    public class Position : BaseModel
    {
        public string Name { get; set; }
        [ForeignKey("DepartmentID")]
        public int DepartmentID { get; set; }
    
        public virtual Department Department { get; set; }       
        
        public virtual ICollection<Employee> Employees { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}