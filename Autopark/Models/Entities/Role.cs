﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autopark.Models.Entities
{
    [Table("Role")]
    public class Role
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool Deleted { get; set; }
        
        public virtual ICollection<Account> Accounts { get; set; }
    }
}
