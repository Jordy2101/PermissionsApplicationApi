using Microsoft.EntityFrameworkCore;
using PermissionsApplication.Domain.PermissionsApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace PermissionsApplication.DataAccess.Context
{
    public class PermissionsApplicationContext : DbContext
    {
        public PermissionsApplicationContext(DbContextOptions<PermissionsApplicationContext> options) : base(options)
        {
        }

        // Entities        
        public DbSet<Permissions> Permissions { get; set; }
        public DbSet<TypePermissions> TypePermissions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
