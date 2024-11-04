using AutoMapper;
using KAF.Service.Proxy.Client;
using KAF.Service.Proxy.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAF.UI.Module
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // Configure your mappings here
            CreateMap<Department, DepartmentDto>();
            CreateMap<AccessToken, AccessTokenDto>();

            // Add more mappings as needed
        }
    }
}
