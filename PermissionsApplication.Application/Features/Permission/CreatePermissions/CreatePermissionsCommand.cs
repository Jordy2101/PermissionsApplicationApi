using AutoMapper;
using FluentValidation;
using PermissionsApplication.Application.DTOs;
using PermissionsApplication.Application.Exceptions;
using PermissionsApplication.Application.Validations;
using PermissionsApplication.Common.Messages;
using PermissionsApplication.DataAccess.Repositories.Base;
using PermissionsApplication.Domain.PermissionsApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermissionsApplication.Application.Features.Permission.CreatePermissions
{
    public class CreatePermissionsCommand : ICreatePermissionsCommand
    {
        readonly IBaseRepository<Permissions> _repository;
        readonly IMapper _mapper;
        public CreatePermissionsCommand(IBaseRepository<Permissions> repository, IMapper mapper) 
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task CreatePermission(PermissionsDto dto)
        {
            try
            {
                var map = _mapper.Map<Permissions>(dto);

                var validationRules = new PermissionsValidations();
                var result = validationRules.Validate(map);

                if (!result.IsValid)
                {
                    var errors = string.Join(" | ", result.Errors);
                    throw new ArgumentException(errors);
                }

                var validationEntity = _repository.FindByCondition(c => c.FirstnameEmployee.Trim().ToUpper() == map.FirstnameEmployee.Trim().ToUpper() 
                                                                    && c.LastnameEmployee.Trim().ToUpper() == map.LastnameEmployee.Trim().ToUpper());

                map = validationEntity.Any() ? throw new ArgumentException(MessageCodes.RecordExist) : map;
               
                _repository.Create(map);
            }
            catch (Exception ex)
            {
                throw new BadRequestException(ex.Message);
            }
        }
    }
}
