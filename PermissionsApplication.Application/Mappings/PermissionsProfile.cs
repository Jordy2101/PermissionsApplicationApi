using AutoMapper;
using PermissionsApplication.Application.DTOs;
using PermissionsApplication.Domain.PermissionsApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermissionsApplication.Application.Mappings
{
    public class PermissionsProfile : Profile
    {
        public PermissionsProfile()
        {
            CreateMap<Permissions, PermissionsDto>().ForMember(c => c.TypePermissionsDto, opt => opt.MapFrom(c => c.TypePermissions)).ReverseMap();
        }
    }
}
