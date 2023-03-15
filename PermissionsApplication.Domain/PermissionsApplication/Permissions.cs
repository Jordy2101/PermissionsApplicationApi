using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermissionsApplication.Domain.PermissionsApplication
{
    [Table("Permissions", Schema = "dbo")]
    public class Permissions
    {
        [Key]
        public int Id { get; set; }
        public string FirstnameEmployee { get; set; }
        public string LastnameEmployee { get; set;}
        public DateTime DatePermissions { get; set; }
        public int IdtypePermission { get; set; }

        [ForeignKey("IdtypePermission")]
        public virtual TypePermissions TypePermissions { get; set; }
    }
}
