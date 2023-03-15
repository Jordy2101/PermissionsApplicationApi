using AutoMapper;
using PermissionsApplication.Application.DTOs;
using PermissionsApplication.Application.Exceptions;
using PermissionsApplication.Common.Messages;
using PermissionsApplication.DataAccess.Repositories.Base;
using PermissionsApplication.Domain.PermissionsApplication;

namespace PermissionsApplication.Application.Features.Permission.GetOnePermissions
{
    public class GetOnePermissionsQueries : IGetOnePermissionsQueries
    {
        readonly IBaseRepository<Permissions> _repository;
        readonly IMapper _mapper;
        public GetOnePermissionsQueries(IBaseRepository<Permissions> repository, IMapper mapper) 
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<PermissionsDto> GetOnePemissions(int id)
        {
            try
            {
                var data = _repository.GetOne(id);

                data = data is null ? throw new NotFoundException(MessageCodes.EmptyCollections, id) : data;

                var map = _mapper.Map<PermissionsDto>(data);

                return map;
            }
            catch (Exception ex)
            {
                throw new BadRequestException(ex.Message);
            }
        }
    }
}
