using AutoMapper;
using CarCore.Entities;
using CarServices.Core.Models;
namespace CarServices.Core.Profiles
{
    public class TransmissionTypeProfile : Profile
    {
        public TransmissionTypeProfile()
        {
            CreateMap<TransmissionType, TransmissionTypeCreationModel>().ForMember(u => u.Name, option => option.MapFrom(src => src.Name))
              .ReverseMap();
        }
    }
}
