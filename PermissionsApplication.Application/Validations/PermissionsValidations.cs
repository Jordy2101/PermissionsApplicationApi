using FluentValidation;
using PermissionsApplication.Domain.PermissionsApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermissionsApplication.Application.Validations
{
    public class PermissionsValidations : AbstractValidator<Permissions>
    {
        public PermissionsValidations()
        {
            RuleFor(x => x.FirstnameEmployee).NotEmpty().WithMessage("Campo Nombre de Empleado es requerido");
            RuleFor(x => x.LastnameEmployee).NotEmpty().WithMessage("Campo Apellido de Empleado es requerido");
            RuleFor(x => x.IdtypePermission).NotEmpty().WithMessage("Campo Tipo de Permiso es requerido");
            RuleFor(x => x.DatePermissions).NotEmpty().WithMessage("Campo Fecha de Permiso es requerido");
        }
    }
}
