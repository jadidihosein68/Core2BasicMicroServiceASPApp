using AutoMapper;
using Service.Common.Models;
using Service.Common.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<SampleModel, SampleModelDto>();
        }
    }
}
