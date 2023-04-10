using AutoMapper;
using CarCore.Entities;
using CarService.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Core.Profiles
{
    public class CarProfile:Profile
    {
        public CarProfile()
        {
            CreateMap<Car, CarCreationModel>().ForMember(u => u.BodyTypeID, option => option.MapFrom(src => src.BodyTypeID))
                                             .ForMember(u => u.BrandID, option => option.MapFrom(src => src.BrandID))
                                             .ForMember(u => u.DriveTypeID, option => option.MapFrom(src => src.DriveTypeID))
                                             .ForMember(u => u.EngineTypeID, option => option.MapFrom(src => src.EngineTypeID))
                                             .ForMember(u => u.EngineVolume, option => option.MapFrom(src => src.EngineVolume))
                                             .ForMember(u => u.ManufacturingDate, option => option.MapFrom(src => src.ManufacturingDate))
                                             .ForMember(u => u.Miliage, option => option.MapFrom(src => src.Miliage))
                                             .ForMember(u => u.ModelID, option => option.MapFrom(src => src.ModelID))
                                             .ForMember(u => u.TransmissionTypeID, option => option.MapFrom(src => src.TransmissionTypeID))
                                             .ReverseMap();
        }
    }
}
