using AutoMapper;
using CarCore.Entities;
using CarServices.Core.Models;
namespace CarServices.Core.Profiles
{
    public class EngineTypeProfile : Profile
    {
        public EngineTypeProfile()
        {
            CreateMap<EngineType, EngineTypeCreationModel>().ForMember(u => u.Name, option => option.MapFrom(src => src.Name))
               .ReverseMap();
        }
    }
}
