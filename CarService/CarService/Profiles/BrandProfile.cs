using AutoMapper;
using CarCore.Entities;
using CarServices.Core.Models;

namespace CarServices.Core.Profiles
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<Brand, BrandCreationModel>().ForMember(u => u.Name, option => option.MapFrom(src => src.Name))
                .ReverseMap();
        }
    }
}
