using AutoMapper;
using CarServices.Core.Models;
using DriveType = CarCore.Entities.DriveType;
namespace CarServices.Core.Profiles
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
