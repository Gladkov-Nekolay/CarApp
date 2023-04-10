﻿using AutoMapper;
using CarCore.Entities;
using CarService.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Core.Profiles
{
    public class ModelOfCarProfile :Profile
    {
        public ModelOfCarProfile()
        {
            CreateMap<ModelOfCar, ModelOfCarCreationModel>().ForMember(u => u.Name, option => option.MapFrom(src => src.Name))
              .ReverseMap();
        }
    }
}
