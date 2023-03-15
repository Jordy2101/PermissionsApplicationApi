using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PermissionsApplication.Application.DTOs;
using PermissionsApplication.Application.Exceptions;
using PermissionsApplication.Common.Messages;
using PermissionsApplication.DataAccess.Repositories.Base;
using PermissionsApplication.Domain.PermissionsApplication;

namespace PermissionsApplication.Application.Features.TypePermission.GetListTypePermissions
{
    public class GetListTypePermissionsQueries : IGetListTypePermissionsQueries
    {
        readonly IBaseRepository<TypePermissions> _repository;
        readonly IMapper _mapper;
        public GetListTypePermissionsQueries(IBaseRepository<TypePermissions> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TypePermissionsDto>> GetListTypePermissions()
        {
            try
            {
                var data = _repository.FindAll();

                data = !data.Any() ? throw new NotFoundException(MessageCodes.EmptyCollections, data) : data;

                var map = _mapper.Map<IEnumerable<TypePermissionsDto>>(data);

                return map;
            }
            catch (Exception ex)
            {
                throw new BadRequestException(ex.Message);
            }
        }
    }
}
