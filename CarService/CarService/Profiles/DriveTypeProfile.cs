using AutoMapper;
using CarService.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DriveType = CarCore.Entities.DriveType;
namespace CarService.Core.Profiles
{
    public class DriveTypeProfile : Profile
    {
        public DriveTypeProfile()
        {
            CreateMap<DriveType, DriveTypeCreationModel>().ForMember(u => u.Name, option => option.MapFrom(src => src.Name))
               .ReverseMap();
        }
    }
}
