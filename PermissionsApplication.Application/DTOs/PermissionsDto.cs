using PermissionsApplication.Domain.PermissionsApplication;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermissionsApplication.Application.DTOs
{
    public class PermissionsDto
    {
        public int Id { get; set; }
        public string FirstnameEmployee { get; set; }
        public string LastnameEmployee { get; set; }
        public DateTime DatePermissions { get; set; }
        public int IdtypePermission { get; set; }

        public virtual TypePermissionsDto TypePermissionsDto { get; set; }
    }
}
