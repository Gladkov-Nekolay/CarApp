using AnnouncementCore.Entities;
using AnnouncementCore.Interfaces;
using AnnouncementCore.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace AnnouncementCore.Services
{
    public class AnnouncementService:IAnnouncementService
    {
        //private readonly IHttpClientFactory _httpClientFactory = null!;
        private readonly IAnnouncementRepository _Repository;
        private readonly IMapper Mapper;
        public AnnouncementService(
            IAnnouncementRepository announcementRepository,
            IMapper mapper)
        {
            _Repository = announcementRepository;
            Mapper = mapper;
        }

        public async Task AddAnnouncementAsync(AnnouncementCreationModel announcement)
        {
            //if (await CheckParamAsync(ServicesURLs.CarService, "Car", announcement.CarID))
            //{
                Announcement MappedAnnouncement = Mapper.Map<AnnouncementCreationModel, Announcement>(announcement);
                await _Repository.AddAnnouncementAsync(MappedAnnouncement);
            //}
            //else
            //   throw new KeyNotFoundException("Car ID is not found");
        }

        public async Task DeleteAnnouncementAsync(long ID)
        {
            await _Repository.DeleteAnnouncementAsync(ID);
        }

        public async Task<List<Announcement>> GetAllAsync(PaginationSettingModel paginationSettiongsModel)
        {
            return await _Repository.GetAllAsync(paginationSettiongsModel);
        }

        public async Task<Announcement> GetByIDAnnouncementAsync(long ID)
        {
            return await _Repository.GetByIDAnnouncementAsync(ID);
        }

        public async Task<List<Announcement>> GetForAccountAnnouncementAsync(PaginationSettingModel paginationSettiongsModel, long ID)
        {
            return await _Repository.GetForAccountAnnouncementAsync(paginationSettiongsModel, ID);
        }

        public async Task UpdateAnnouncementAsync(Announcement announcement)
        {
            //if (await CheckParamAsync(ServicesURLs.CarService, "Car", announcement.CarID))
            //{
                await _Repository.UpdateAnnouncementAsync(announcement);
            //}
            //else
                //throw new KeyNotFoundException("Car ID is not found");
        }

        /*public async Task<bool> CheckParamAsync(string ServiceURL, string controller, long ID)
        {
            HttpClient client = _httpClientFactory.CreateClient();
            bool? IsCarExist = await client.GetFromJsonAsync<bool>
                ($"{ServiceURL}/api/{controller}/IsExist?ID={ID}");
            if (IsCarExist is not null)
            {
                return IsCarExist.Value;
            }
            throw new Exception();
        }*/
    }
}
