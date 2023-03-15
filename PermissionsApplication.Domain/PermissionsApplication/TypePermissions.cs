﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermissionsApplication.Domain.PermissionsApplication
{
    [Table("TypePermissions", Schema = "dbo")]
    public class TypePermissions
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
