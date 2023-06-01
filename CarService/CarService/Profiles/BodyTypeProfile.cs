using AutoMapper;
using CarCore.Entities;
using CarServices.Core.Models;

namespace CarServices.Core.Profiles
{
    public class BodyTypeProfile : Profile
    {
        public BodyTypeProfile()
        {
            CreateMap<BodyType, BodyTypeCreationModel>().ForMember(u => u.Name, option => option.MapFrom(src => src.Name))
                                                        .ReverseMap();
        }
    }
}
