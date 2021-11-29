using System.ComponentModel.DataAnnotations.Schema;

namespace Autopark.Models.Entities
{
    [Table("Account")]
    public class Account : BaseModel
    {
        public string Login { get; set; }
        public string Password { get; set; }
        [ForeignKey("EmployeeID")]
        public int EmployeeID { get; set; }
        [ForeignKey("RoleID")]
        public int RoleID { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Role Role { get; set; }

        public override string ToString()
        {
            return Login;
        }
    }
}