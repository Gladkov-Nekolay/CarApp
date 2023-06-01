using AutoMapper;
using CarCore.Entities;
using CarServices.Core.Models;

namespace CarServices.Core.Profiles
{
    public class ModelOfCarProfile : Profile
    {
        public ModelOfCarProfile()
        {
            CreateMap<ModelOfCar, ModelOfCarCreationModel>().ForMember(u => u.Name, option => option.MapFrom(src => src.Name))
              .ReverseMap();
        }
    }
}
