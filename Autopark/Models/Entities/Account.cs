using System.ComponentModel.DataAnnotations.Schema;

namespace Autopark.Models.Entities
{
    [Table("Account")]
    public class Account
    {
        public int ID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        [ForeignKey("EmployeeID")]
        public int EmployeeID { get; set; }
        [ForeignKey("RoleID")]
        public int RoleID { get; set; }
        public bool Deleted { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Role Role { get; set; }
    }
}