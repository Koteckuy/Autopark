using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autopark.Models.Entities
{
    [Table("Role")]
    public class Role : BaseModel
    {
        public string Name { get; set; }
        
        public virtual ICollection<Account> Accounts { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
