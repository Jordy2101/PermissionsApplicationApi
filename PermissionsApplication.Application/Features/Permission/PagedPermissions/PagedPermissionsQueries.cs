using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PermissionsApplication.Application.DTOs;
using PermissionsApplication.Application.Exceptions;
using PermissionsApplication.Common.Dto;
using PermissionsApplication.Common.Filter;
using PermissionsApplication.Common.Messages;
using PermissionsApplication.Common.Paged;
using PermissionsApplication.DataAccess.Repositories.Base;
using PermissionsApplication.Domain.PermissionsApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermissionsApplication.Application.Features.Permission.PagedPermissions
{
    public class PagedPermissionsQueries : IPagedPermissionsQueries
    {
        readonly IBaseRepository<Permissions> _repository;
        readonly IMapper _mapper;
        public PagedPermissionsQueries(IBaseRepository<Permissions> repository, IMapper mapper) 
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<Pagination<PermissionsDto>> GetPagedPermissions(PermissionsFilter filter)
        {
            try
            {
                var data = filter.Keyword is null ? _repository.FindAll().Include(c=> c.TypePermissions) : 
                                                    _repository.FindByCondition(c => c.FirstnameEmployee.Contains(filter.Keyword) || c.LastnameEmployee.Contains(filter.Keyword)).Include(c=> c.TypePermissions);

                data = !data.Any() ? throw new NotFoundException(MessageCodes.EmptyCollections, filter) : data;

                var map = _mapper.Map<IEnumerable<PermissionsDto>>(data);

                var pag = PagedList<PermissionsDto>.Create(map, filter.PageNumber, filter.PageSize);

                return new Pagination<PermissionsDto>()
                {
                    Data = pag,
                    TotalCount = data.Count(),
                    PageSize = pag.PageSize,
                    CurrentPage = pag.CurrentPage,
                    TotalPages = pag.TotalPages
                };
            }
            catch (Exception ex)
            {
                throw new BadRequestException(ex.Message);
            }
        }
    }
}
