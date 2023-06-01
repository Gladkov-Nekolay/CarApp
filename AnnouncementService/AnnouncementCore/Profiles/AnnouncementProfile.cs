using AnnouncementCore.Entities;
using AnnouncementCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace AnnouncementCore.Profiles
{
    public class AnnouncementProfile:Profile
    {
        public AnnouncementProfile()
        {
            CreateMap<Announcement, AnnouncementCreationModel>().ForMember(u => u.CarID, option => option.MapFrom(src => src.CarID))
                                                                .ForMember(u => u.Description, option => option.MapFrom(src => src.Description))
                                                                .ForMember(u => u.IsSold, option => option.MapFrom(src => src.IsSold))
                                                                .ForMember(u => u.OwnerID, option => option.MapFrom(src => src.OwnerID))
                                                                .ForMember(u => u.Price, option => option.MapFrom(src => src.Price))
                                                                .ReverseMap();
        }
    }
}
