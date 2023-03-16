using AutoMapper;
using PermissionsApplication.Application.DTOs;
using PermissionsApplication.Application.Exceptions;
using PermissionsApplication.DataAccess.Repositories.Base;
using PermissionsApplication.Domain.PermissionsApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermissionsApplication.Application.Features.Permission.DeletePermissions
{
    public class DeletePermissionsCommand : IDeletePermissionsCommand
    {
        readonly IBaseRepository<Permissions> _repository;
        readonly IMapper _mapper;
        public DeletePermissionsCommand(IBaseRepository<Permissions> repository, IMapper mapper) 
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task DeletePermissions(int id)
        {
            try
            {
                var data = _repository.GetOne(id);

                 _repository.Delete(data);
            }
            catch (Exception ex)
            {
                throw new BadRequestException(ex.Message);
            }
        }
    }
}
