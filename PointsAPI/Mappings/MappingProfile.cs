using AutoMapper;
using PointsAPI.Dtos;
using PointsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsAPI.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<PointEntity, PointDto>().ReverseMap();
        }
    }
}
