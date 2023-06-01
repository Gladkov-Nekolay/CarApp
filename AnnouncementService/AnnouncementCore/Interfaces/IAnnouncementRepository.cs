using AnnouncementCore.Entities;
using AnnouncementCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnouncementCore.Interfaces
{
    public interface IAnnouncementRepository
    {
        public Task AddAnnouncementAsync(Announcement announcement);
        public Task UpdateAnnouncementAsync(Announcement announcement);
        public Task<List<Announcement>> GetAllAsync(PaginationSettingModel paginationSettiongsModel);
        public Task<List<Announcement>> GetForAccountAnnouncementAsync(PaginationSettingModel paginationSettiongsModel, long ID);
        public Task DeleteAnnouncementAsync(long ID);
        public Task<Announcement> GetByIDAnnouncementAsync(long ID);
    }
}
